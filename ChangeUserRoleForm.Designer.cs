namespace БД_Телестудии
{
    partial class ChangeUserRoleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.changeUserRoleCommand = new System.Data.SqlClient.SqlCommand();
            this.changeUserRoleButton = new БД_Телестудии.RoundButton();
            this.loginTextBox = new БД_Телестудии.RoundTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Новая роль";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Смена роли";
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
            this.userRoleComboBox.Location = new System.Drawing.Point(18, 185);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(215, 28);
            this.userRoleComboBox.TabIndex = 39;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // changeUserRoleCommand
            // 
            this.changeUserRoleCommand.CommandText = "ChangeUserRole";
            this.changeUserRoleCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.changeUserRoleCommand.Connection = this.sqlConnection1;
            this.changeUserRoleCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@login", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newRole", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // changeUserRoleButton
            // 
            this.changeUserRoleButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.changeUserRoleButton.BorderColor = System.Drawing.Color.White;
            this.changeUserRoleButton.BorderWidth = 2F;
            this.changeUserRoleButton.ButtonText = "Сменить";
            this.changeUserRoleButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUserRoleButton.ForeColor = System.Drawing.Color.White;
            this.changeUserRoleButton.Location = new System.Drawing.Point(7, 231);
            this.changeUserRoleButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.changeUserRoleButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.changeUserRoleButton.Name = "changeUserRoleButton";
            this.changeUserRoleButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.changeUserRoleButton.Radius = 15;
            this.changeUserRoleButton.Size = new System.Drawing.Size(168, 72);
            this.changeUserRoleButton.TabIndex = 38;
            this.changeUserRoleButton.UseMouseOverBackColor = true;
            this.changeUserRoleButton.Click += new System.EventHandler(this.changeUserRoleButton_Click);
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
            this.loginTextBox.Location = new System.Drawing.Point(7, 68);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.loginTextBox.MaxLength = 35;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Radius = 10;
            this.loginTextBox.Size = new System.Drawing.Size(168, 53);
            this.loginTextBox.TabIndex = 35;
            this.loginTextBox.UseSystemPasswordChar = false;
            // 
            // ChangeUserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(245, 310);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.changeUserRoleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserRoleForm";
            this.Text = "Новая роль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton changeUserRoleButton;
        private System.Windows.Forms.Label label2;
        private RoundTextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand changeUserRoleCommand;
    }
}