namespace UserHasUkol
{
    partial class PasswordForm
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
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserList = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 16;
            this.listBoxUsers.Location = new System.Drawing.Point(13, 152);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(1025, 308);
            this.listBoxUsers.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(61, 43);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(268, 22);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(471, 43);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(425, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(57, 20);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(55, 16);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Uživatel";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(467, 20);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(43, 16);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Heslo";
            // 
            // labelUserList
            // 
            this.labelUserList.AutoSize = true;
            this.labelUserList.Location = new System.Drawing.Point(13, 132);
            this.labelUserList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserList.Name = "labelUserList";
            this.labelUserList.Size = new System.Drawing.Size(130, 16);
            this.labelUserList.TabIndex = 5;
            this.labelUserList.Text = "Uživatelé v seznamu";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(45, 485);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(181, 44);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Uložit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(711, 104);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(327, 24);
            this.comboBoxRole.TabIndex = 7;
            this.comboBoxRole.Items.AddRange(new object[] { "Admin", "Guest" });
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(708, 85);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(39, 16);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(243, 485);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 44);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Přidat";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelUserList);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.listBoxUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserList;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonAdd;
    }
}