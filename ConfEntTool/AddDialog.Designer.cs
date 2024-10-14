namespace ConfEntTool
{
    partial class AddDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PasswordDisable = new System.Windows.Forms.CheckBox();
            this.CopyURL = new System.Windows.Forms.CheckBox();
            this.ConfNameLab = new System.Windows.Forms.Label();
            this.URLLab = new System.Windows.Forms.Label();
            this.ConfPassLab = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewElBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.NewElBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(135, 24);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 26);
            this.NameBox.TabIndex = 0;
            // 
            // LinkBox
            // 
            this.LinkBox.Location = new System.Drawing.Point(135, 54);
            this.LinkBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(176, 26);
            this.LinkBox.TabIndex = 1;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(135, 84);
            this.PassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(176, 26);
            this.PassBox.TabIndex = 2;
            // 
            // PasswordDisable
            // 
            this.PasswordDisable.AutoSize = true;
            this.PasswordDisable.Location = new System.Drawing.Point(8, 139);
            this.PasswordDisable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordDisable.Name = "PasswordDisable";
            this.PasswordDisable.Size = new System.Drawing.Size(125, 24);
            this.PasswordDisable.TabIndex = 3;
            this.PasswordDisable.Text = "Без пароля";
            this.PasswordDisable.UseVisualStyleBackColor = true;
            this.PasswordDisable.CheckedChanged += new System.EventHandler(this.PasswordDisable_CheckedChanged);
            // 
            // CopyURL
            // 
            this.CopyURL.AutoSize = true;
            this.CopyURL.Location = new System.Drawing.Point(8, 115);
            this.CopyURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyURL.Name = "CopyURL";
            this.CopyURL.Size = new System.Drawing.Size(303, 24);
            this.CopyURL.TabIndex = 4;
            this.CopyURL.Text = "Копировать ссылку, а не пароль";
            this.CopyURL.UseVisualStyleBackColor = true;
            this.CopyURL.CheckedChanged += new System.EventHandler(this.CopyURL_CheckedChanged);
            // 
            // ConfNameLab
            // 
            this.ConfNameLab.AutoSize = true;
            this.ConfNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfNameLab.Location = new System.Drawing.Point(5, 27);
            this.ConfNameLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfNameLab.Name = "ConfNameLab";
            this.ConfNameLab.Size = new System.Drawing.Size(96, 20);
            this.ConfNameLab.TabIndex = 5;
            this.ConfNameLab.Text = "Название:";
            // 
            // URLLab
            // 
            this.URLLab.AutoSize = true;
            this.URLLab.Location = new System.Drawing.Point(5, 57);
            this.URLLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URLLab.Name = "URLLab";
            this.URLLab.Size = new System.Drawing.Size(77, 20);
            this.URLLab.TabIndex = 6;
            this.URLLab.Text = "Ссылка:";
            // 
            // ConfPassLab
            // 
            this.ConfPassLab.AutoSize = true;
            this.ConfPassLab.Location = new System.Drawing.Point(5, 87);
            this.ConfPassLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfPassLab.Name = "ConfPassLab";
            this.ConfPassLab.Size = new System.Drawing.Size(78, 20);
            this.ConfPassLab.TabIndex = 7;
            this.ConfPassLab.Text = "Пароль:";
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(11, 191);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(116, 27);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Добавить";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewElBox
            // 
            this.NewElBox.Controls.Add(this.ConfNameLab);
            this.NewElBox.Controls.Add(this.NameBox);
            this.NewElBox.Controls.Add(this.PasswordDisable);
            this.NewElBox.Controls.Add(this.CopyURL);
            this.NewElBox.Controls.Add(this.URLLab);
            this.NewElBox.Controls.Add(this.ConfPassLab);
            this.NewElBox.Controls.Add(this.LinkBox);
            this.NewElBox.Controls.Add(this.PassBox);
            this.NewElBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewElBox.Location = new System.Drawing.Point(11, 5);
            this.NewElBox.Name = "NewElBox";
            this.NewElBox.Size = new System.Drawing.Size(351, 181);
            this.NewElBox.TabIndex = 9;
            this.NewElBox.TabStop = false;
            this.NewElBox.Text = "Добавление конференции";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(247, 191);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(116, 27);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 222);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewElBox);
            this.Controls.Add(this.EnterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.NewElBox.ResumeLayout(false);
            this.NewElBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.CheckBox PasswordDisable;
        private System.Windows.Forms.CheckBox CopyURL;
        private System.Windows.Forms.Label ConfNameLab;
        private System.Windows.Forms.Label URLLab;
        private System.Windows.Forms.Label ConfPassLab;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox NewElBox;
        private System.Windows.Forms.Button CancelButton;
    }
}