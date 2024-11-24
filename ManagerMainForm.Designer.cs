namespace БД_Телестудии
{
    partial class ManagerMainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.openAuthEditFormButton = new БД_Телестудии.RoundButton();
            this.openVideosFormButton = new БД_Телестудии.RoundButton();
            this.openBroadcastsFormButton = new БД_Телестудии.RoundButton();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(69, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(390, 37);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Управление телестудией";
            // 
            // openAuthEditFormButton
            // 
            this.openAuthEditFormButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openAuthEditFormButton.BorderColor = System.Drawing.Color.White;
            this.openAuthEditFormButton.BorderWidth = 2F;
            this.openAuthEditFormButton.ButtonText = "Сотрудники";
            this.openAuthEditFormButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAuthEditFormButton.ForeColor = System.Drawing.Color.White;
            this.openAuthEditFormButton.Location = new System.Drawing.Point(160, 67);
            this.openAuthEditFormButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.openAuthEditFormButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.openAuthEditFormButton.Name = "openAuthEditFormButton";
            this.openAuthEditFormButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.openAuthEditFormButton.Radius = 10;
            this.openAuthEditFormButton.Size = new System.Drawing.Size(210, 77);
            this.openAuthEditFormButton.TabIndex = 11;
            this.openAuthEditFormButton.UseMouseOverBackColor = true;
            this.openAuthEditFormButton.Click += new System.EventHandler(this.openAuthEditFormButton_Click);
            // 
            // openVideosFormButton
            // 
            this.openVideosFormButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openVideosFormButton.BorderColor = System.Drawing.Color.White;
            this.openVideosFormButton.BorderWidth = 2F;
            this.openVideosFormButton.ButtonText = "Видеоматериалы";
            this.openVideosFormButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openVideosFormButton.ForeColor = System.Drawing.Color.White;
            this.openVideosFormButton.Location = new System.Drawing.Point(160, 154);
            this.openVideosFormButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.openVideosFormButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.openVideosFormButton.Name = "openVideosFormButton";
            this.openVideosFormButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.openVideosFormButton.Radius = 10;
            this.openVideosFormButton.Size = new System.Drawing.Size(210, 77);
            this.openVideosFormButton.TabIndex = 12;
            this.openVideosFormButton.UseMouseOverBackColor = true;
            this.openVideosFormButton.Click += new System.EventHandler(this.openVideosFormButton_Click);
            // 
            // openBroadcastsFormButton
            // 
            this.openBroadcastsFormButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openBroadcastsFormButton.BorderColor = System.Drawing.Color.White;
            this.openBroadcastsFormButton.BorderWidth = 2F;
            this.openBroadcastsFormButton.ButtonText = "Трансляции";
            this.openBroadcastsFormButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBroadcastsFormButton.ForeColor = System.Drawing.Color.White;
            this.openBroadcastsFormButton.Location = new System.Drawing.Point(160, 241);
            this.openBroadcastsFormButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.openBroadcastsFormButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.openBroadcastsFormButton.Name = "openBroadcastsFormButton";
            this.openBroadcastsFormButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.openBroadcastsFormButton.Radius = 10;
            this.openBroadcastsFormButton.Size = new System.Drawing.Size(210, 77);
            this.openBroadcastsFormButton.TabIndex = 13;
            this.openBroadcastsFormButton.UseMouseOverBackColor = true;
            this.openBroadcastsFormButton.Click += new System.EventHandler(this.openBroadcastsFormButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(12, 351);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 23);
            this.logOutButton.TabIndex = 14;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 386);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.openBroadcastsFormButton);
            this.Controls.Add(this.openVideosFormButton);
            this.Controls.Add(this.openAuthEditFormButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerMainForm";
            this.Text = "БД Телестудии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerMainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private RoundButton openAuthEditFormButton;
        private RoundButton openVideosFormButton;
        private RoundButton openBroadcastsFormButton;
        private System.Windows.Forms.Button logOutButton;
    }
}