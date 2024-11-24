namespace БД_Телестудии
{
    partial class ChangeUserPassForm
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
            this.passwordConfirmTextBox = new БД_Телестудии.RoundTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changeUserPassButton = new БД_Телестудии.RoundButton();
            this.passwordTextBox = new БД_Телестудии.RoundTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox = new БД_Телестудии.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.changeUserPassCommand = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
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
            this.passwordConfirmTextBox.MaxLength = 35;
            this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
            this.passwordConfirmTextBox.Radius = 10;
            this.passwordConfirmTextBox.Size = new System.Drawing.Size(242, 59);
            this.passwordConfirmTextBox.TabIndex = 32;
            this.passwordConfirmTextBox.UseSystemPasswordChar = true;
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
            this.label4.TabIndex = 31;
            this.label4.Text = "Подтвердите пароль";
            // 
            // changeUserPassButton
            // 
            this.changeUserPassButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.changeUserPassButton.BorderColor = System.Drawing.Color.White;
            this.changeUserPassButton.BorderWidth = 2F;
            this.changeUserPassButton.ButtonText = "Сменить";
            this.changeUserPassButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUserPassButton.ForeColor = System.Drawing.Color.White;
            this.changeUserPassButton.Location = new System.Drawing.Point(6, 257);
            this.changeUserPassButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.changeUserPassButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.changeUserPassButton.Name = "changeUserPassButton";
            this.changeUserPassButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.changeUserPassButton.Radius = 15;
            this.changeUserPassButton.Size = new System.Drawing.Size(168, 72);
            this.changeUserPassButton.TabIndex = 30;
            this.changeUserPassButton.UseMouseOverBackColor = true;
            this.changeUserPassButton.Click += new System.EventHandler(this.changeUserPassButton_Click);
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
            this.passwordTextBox.MaxLength = 35;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Radius = 10;
            this.passwordTextBox.Size = new System.Drawing.Size(242, 59);
            this.passwordTextBox.TabIndex = 29;
            this.passwordTextBox.UseSystemPasswordChar = true;
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
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Новый пароль";
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
            this.loginTextBox.MaxLength = 35;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Radius = 10;
            this.loginTextBox.Size = new System.Drawing.Size(219, 59);
            this.loginTextBox.TabIndex = 27;
            this.loginTextBox.UseSystemPasswordChar = false;
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
            this.label3.TabIndex = 26;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "Смена пароля";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // changeUserPassCommand
            // 
            this.changeUserPassCommand.CommandText = "ChangeUserPassword";
            this.changeUserPassCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.changeUserPassCommand.Connection = this.sqlConnection1;
            this.changeUserPassCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newPassword", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // ChangeUserPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.passwordConfirmTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changeUserPassButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserPassForm";
            this.Text = "Новый пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundTextBox passwordConfirmTextBox;
        private System.Windows.Forms.Label label4;
        private RoundButton changeUserPassButton;
        private RoundTextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private RoundTextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand changeUserPassCommand;
    }
}