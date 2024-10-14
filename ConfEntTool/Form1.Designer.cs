namespace ConfEntTool
{
    partial class CET
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfType = new System.Windows.Forms.ComboBox();
            this.OpenBut = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зАГЛУШКАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конференцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКонференциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКонференциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfPick = new System.Windows.Forms.GroupBox();
            this.изменитьКонференциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.ConfPick.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfType
            // 
            this.ConfType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfType.FormattingEnabled = true;
            this.ConfType.Location = new System.Drawing.Point(6, 27);
            this.ConfType.Name = "ConfType";
            this.ConfType.Size = new System.Drawing.Size(256, 37);
            this.ConfType.TabIndex = 0;
            // 
            // OpenBut
            // 
            this.OpenBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenBut.Location = new System.Drawing.Point(268, 25);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(103, 33);
            this.OpenBut.TabIndex = 1;
            this.OpenBut.Text = "Открыть";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.конференцииToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(401, 40);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зАГЛУШКАToolStripMenuItem});
            this.файлToolStripMenuItem.Enabled = false;
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зАГЛУШКАToolStripMenuItem
            // 
            this.зАГЛУШКАToolStripMenuItem.Enabled = false;
            this.зАГЛУШКАToolStripMenuItem.Name = "зАГЛУШКАToolStripMenuItem";
            this.зАГЛУШКАToolStripMenuItem.Size = new System.Drawing.Size(259, 40);
            this.зАГЛУШКАToolStripMenuItem.Text = "*ЗАГЛУШКА*";
            // 
            // конференцииToolStripMenuItem
            // 
            this.конференцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКонференциюToolStripMenuItem,
            this.изменитьКонференциюToolStripMenuItem,
            this.удалитьКонференциюToolStripMenuItem});
            this.конференцииToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.конференцииToolStripMenuItem.Name = "конференцииToolStripMenuItem";
            this.конференцииToolStripMenuItem.Size = new System.Drawing.Size(184, 36);
            this.конференцииToolStripMenuItem.Text = "Конференции";
            // 
            // добавитьКонференциюToolStripMenuItem
            // 
            this.добавитьКонференциюToolStripMenuItem.Name = "добавитьКонференциюToolStripMenuItem";
            this.добавитьКонференциюToolStripMenuItem.Size = new System.Drawing.Size(392, 40);
            this.добавитьКонференциюToolStripMenuItem.Text = "Добавить конференцию";
            this.добавитьКонференциюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКонференциюToolStripMenuItem_Click);
            // 
            // удалитьКонференциюToolStripMenuItem
            // 
            this.удалитьКонференциюToolStripMenuItem.Name = "удалитьКонференциюToolStripMenuItem";
            this.удалитьКонференциюToolStripMenuItem.Size = new System.Drawing.Size(392, 40);
            this.удалитьКонференциюToolStripMenuItem.Text = "Удалить конференцию";
            this.удалитьКонференциюToolStripMenuItem.Click += new System.EventHandler(this.удалитьКонференциюToolStripMenuItem_Click);
            // 
            // ConfPick
            // 
            this.ConfPick.Controls.Add(this.ConfType);
            this.ConfPick.Controls.Add(this.OpenBut);
            this.ConfPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfPick.Location = new System.Drawing.Point(12, 29);
            this.ConfPick.Name = "ConfPick";
            this.ConfPick.Size = new System.Drawing.Size(377, 68);
            this.ConfPick.TabIndex = 4;
            this.ConfPick.TabStop = false;
            this.ConfPick.Text = "Выбор конференции";
            // 
            // изменитьКонференциюToolStripMenuItem
            // 
            this.изменитьКонференциюToolStripMenuItem.Name = "изменитьКонференциюToolStripMenuItem";
            this.изменитьКонференциюToolStripMenuItem.Size = new System.Drawing.Size(392, 40);
            this.изменитьКонференциюToolStripMenuItem.Text = "Изменить конференцию";
            this.изменитьКонференциюToolStripMenuItem.Click += new System.EventHandler(this.изменитьКонференциюToolStripMenuItem_Click);
            // 
            // CET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 103);
            this.Controls.Add(this.ConfPick);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CET";
            this.Text = "CET";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ConfPick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConfType;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зАГЛУШКАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конференцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКонференциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКонференциюToolStripMenuItem;
        private System.Windows.Forms.GroupBox ConfPick;
        private System.Windows.Forms.ToolStripMenuItem изменитьКонференциюToolStripMenuItem;
    }
}

