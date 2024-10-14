using ConfEntTool;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfEntTool
{
    
    public partial class CET : Form
    {
        LinksContext db;
        private int counter = 0;
        public CET()
        {
            InitializeComponent();
            UpdateComboBox();
        }
        public void UpdateComboBox()
        {
            //Неоптимально, но задачу выполняет в конкретном контексте
            db = new LinksContext();
            ConfType.Items.Clear();
            var links = db.Links.ToList();
            string[] items = new string[links.Count];
            for(int i = 0; i < links.Count; i++)
            {
                items[i] = links[i].LinkName;
            }
            Array.Sort(items);
            ConfType.Items.AddRange(items);
            ConfType.Text = (string)ConfType.Items[0];
        }

        private void OpenBut_Click(object sender, EventArgs e)
        {
            var obj = db.Links.FirstOrDefault(l => l.LinkName == ConfType.Text);
            if (obj.CopyUrl == true)
            {
                Clipboard.SetText(obj.LinkUrl);
                new ToastContentBuilder()
                    .AddText("Ссылка сохранена в буфер обмена")
                    .Show();
                if (obj.PassEnabled == true)
                {
                    new ToastContentBuilder()
                        .AddText($"Пароль: {obj.Password}")
                        .Show();
                }
            }
            else
            {
                string target = obj.LinkUrl;
                System.Diagnostics.Process.Start(target);
                if (obj.PassEnabled == true)
                {
                    Clipboard.SetText(obj.Password);
                    new ToastContentBuilder()
                        .AddText("Пароль сохранён в буфер обмена")
                        .Show();
                }
            }
        }

        private void добавитьКонференциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDialog addDialog = new AddDialog();
            addDialog.ShowDialog();
            UpdateComboBox();
        }

        private void удалитьКонференциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(ConfType.Text))
                {
                    MessageBox.Show("Конференция не выбрана, удаление невозможно");
                }
                else
                {
                    var obj = db.Links.FirstOrDefault(l => l.LinkName == ConfType.Text);
                    db.Remove(obj);
                    db.Links.OrderBy(l => l.LinkName);
                    db.SaveChanges();
                    UpdateComboBox();
                }
            }
        }

        private void изменитьКонференциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ConfType.Text))
            {
                MessageBox.Show("Конференция не выбрана, изменение невозможно");
            }
            else
            {
                var obj = db.Links.FirstOrDefault(l => l.LinkName == ConfType.Text);
                AddDialog addDialog = new AddDialog(obj.Id);
                addDialog.ShowDialog();
                UpdateComboBox();
            }
        }
    }
}
