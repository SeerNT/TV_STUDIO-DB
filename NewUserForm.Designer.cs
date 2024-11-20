namespace БД_Телестудии
{
    partial class NewUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.passwordConfirmTextBox = new БД_Телестудии.RoundTextBox();
            this.addNewUserButton = new БД_Телестудии.RoundButton();
            this.passwordTextBox = new БД_Телестудии.RoundTextBox();
            this.loginTextBox = new БД_Телестудии.RoundTextBox();
            this.newUserCommand = new System.Data.SqlClient.SqlCommand();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавление пользователя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Подтвердите пароль";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Роль";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // passwordConfirmTextBox
            // 
            this.passwordConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordConfirmTextBox.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordConfirmTextBox.BorderColor = System.Drawing.Color.White;
            this.passwordConfirmTextBox.BorderWidth = 7F;
            this.passwordConfirmTextBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirmTextBox.Location = new System.Drawing.Point(294, 167);
            this.passwordConfirmTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Radius = 10;
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(242, 56);
            this.passwordConfirmTextBox.TabIndex = 22;
            this.passwordConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.addNewUserButton.BorderColor = System.Drawing.Color.White;
            this.addNewUserButton.BorderWidth = 2F;
            this.addNewUserButton.ButtonText = "Добавить";
            this.addNewUserButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserButton.ForeColor = System.Drawing.Color.White;
            this.addNewUserButton.Location = new System.Drawing.Point(6, 348);
            this.addNewUserButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addNewUserButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewUserButton.Radius = 15;
            this.addNewUserButton.Size = new System.Drawing.Size(168, 72);
            this.addNewUserButton.TabIndex = 20;
            this.addNewUserButton.UseMouseOverBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordTextBox.BorderColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderWidth = 7F;
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(6, 167);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Radius = 10;
            this.passwordTextBox.Size = new System.Drawing.Size(242, 56);
            this.passwordTextBox.TabIndex = 19;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginTextBox.BorderColor = System.Drawing.Color.White;
            this.loginTextBox.BorderWidth = 7F;
            this.loginTextBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(6, 69);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Radius = 10;
            this.loginTextBox.Size = new System.Drawing.Size(219, 56);
            this.loginTextBox.TabIndex = 17;
            this.loginTextBox.UseSystemPasswordChar = false;
            // 
            // newUserCommand
            // 
            this.newUserCommand.CommandText = "NewUser";
            this.newUserCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.newUserCommand.Connection = this.sqlConnection1;
            this.newUserCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@password", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@role", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Items.AddRange(new object[] {
            "Менеджер",
            "Режиссер",
            "Продюсер",
            "Монтажер",
            "Член съёмочной команды"});
            this.userRoleComboBox.Location = new System.Drawing.Point(16, 297);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(215, 28);
            this.userRoleComboBox.TabIndex = 40;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 422);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.Text = "Новый пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundButton addNewUserButton;
        private RoundTextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private RoundTextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private RoundTextBox passwordConfirmTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand newUserCommand;
        private System.Windows.Forms.ComboBox userRoleComboBox;
    }
}