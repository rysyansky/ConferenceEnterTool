using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfEntTool;

namespace ConfEntTool
{
    public partial class AddDialog : Form
    {
        LinksContext db = new LinksContext();
        bool CopyLink = false;
        bool PassEnabled = true;
        int ObjId;
        public AddDialog()
        {
            InitializeComponent();
        }
        public AddDialog(int Id)
        {
            this.ObjId = Id;
            InitializeComponent();
            var obj = db.Links.Find(Id);
            if (obj != null)
            {
                NameBox.Text = obj.LinkName;
                LinkBox.Text = obj.LinkUrl;
                PassBox.Text = obj.Password;
                if (!obj.PassEnabled) 
                { 
                    PasswordDisable.Checked = true;
                }
                if (obj.CopyUrl)
                {
                    CopyURL.Checked = true;
                }
                EnterButton.Text = "Изменить";
            }
            else
            {
                MessageBox.Show("Такой конференции не существует!");
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) )
            {
                errorProvider.SetError(NameBox, "Введите название");
            }
            else if (string.IsNullOrEmpty(LinkBox.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(LinkBox, "Введите ссылку");
            }
            else if (string.IsNullOrEmpty(PassBox.Text) && PassEnabled == true)
            {
                errorProvider.Clear();
                errorProvider.SetError(PassBox, "Введите пароль");
            }
            else
            {
                if (EnterButton.Text == "Добавить")
                {
                    ConfLink link = new ConfLink() { LinkName = NameBox.Text, LinkUrl = LinkBox.Text, Password = PassBox.Text, PassEnabled = this.PassEnabled, CopyUrl = CopyLink };
                    errorProvider.Clear();
                    if (PassEnabled == false) { link.Password = "NULL"; }
                    db.Add(link);
                    db.Links.OrderBy(l => l.LinkName);
                    db.SaveChanges();
                    //MessageBox.Show("Имя: " + link.LinkName + "\nСсылка: " + link.LinkUrl + "\nПароль: " + link.Password + "\nП.Флаг: " + link.PassEnabled + "\nС.Флаг: " + link.CopyUrl
                    this.Close();
                }
                else
                {
                    var obj = db.Links.FirstOrDefault(s => s.Id.Equals(ObjId));
                    obj.LinkName = NameBox.Text;
                    obj.LinkUrl = LinkBox.Text;
                    obj.Password = PassBox.Text;
                    obj.PassEnabled = this.PassEnabled;
                    obj.CopyUrl = this.CopyLink;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void PasswordDisable_CheckedChanged(object sender, EventArgs e)
        {
            PassBox.Enabled = !PassBox.Enabled;
            ConfPassLab.Enabled = !ConfPassLab.Enabled;
            PassEnabled = !PassEnabled;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyURL_CheckedChanged(object sender, EventArgs e)
        {
            CopyLink = !CopyLink;
        }
    }
}
