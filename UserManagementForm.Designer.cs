namespace БД_Телестудии
{
    partial class UserManagementForm
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
            System.Windows.Forms.Label userLoginLabel;
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.AuthTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.authDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.editUserRoleButton = new БД_Телестудии.RoundButton();
            this.editUserPasswordButton = new БД_Телестудии.RoundButton();
            this.newUserButton = new БД_Телестудии.RoundButton();
            this.userLoginLabel1 = new System.Windows.Forms.Label();
            this.deleteUserButton = new БД_Телестудии.RoundButton();
            userLoginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "Auth";
            this.authBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = this.authTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // authDataGridView
            // 
            this.authDataGridView.AllowUserToAddRows = false;
            this.authDataGridView.AllowUserToDeleteRows = false;
            this.authDataGridView.AutoGenerateColumns = false;
            this.authDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.authDataGridView.DataSource = this.authBindingSource;
            this.authDataGridView.Location = new System.Drawing.Point(16, 34);
            this.authDataGridView.Name = "authDataGridView";
            this.authDataGridView.ReadOnly = true;
            this.authDataGridView.Size = new System.Drawing.Size(294, 211);
            this.authDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userLogin";
            this.dataGridViewTextBoxColumn1.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "userPosition";
            this.dataGridViewTextBoxColumn3.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Сотрудники";
            // 
            // editUserRoleButton
            // 
            this.editUserRoleButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.editUserRoleButton.BorderColor = System.Drawing.Color.White;
            this.editUserRoleButton.BorderWidth = 2F;
            this.editUserRoleButton.ButtonText = "Смена роли";
            this.editUserRoleButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserRoleButton.ForeColor = System.Drawing.Color.White;
            this.editUserRoleButton.Location = new System.Drawing.Point(323, 183);
            this.editUserRoleButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.editUserRoleButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.editUserRoleButton.Name = "editUserRoleButton";
            this.editUserRoleButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.editUserRoleButton.Radius = 10;
            this.editUserRoleButton.Size = new System.Drawing.Size(253, 68);
            this.editUserRoleButton.TabIndex = 16;
            this.editUserRoleButton.UseMouseOverBackColor = true;
            this.editUserRoleButton.Click += new System.EventHandler(this.editUserRoleButton_Click);
            // 
            // editUserPasswordButton
            // 
            this.editUserPasswordButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.editUserPasswordButton.BorderColor = System.Drawing.Color.White;
            this.editUserPasswordButton.BorderWidth = 2F;
            this.editUserPasswordButton.ButtonText = "Смена пароля";
            this.editUserPasswordButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserPasswordButton.ForeColor = System.Drawing.Color.White;
            this.editUserPasswordButton.Location = new System.Drawing.Point(323, 105);
            this.editUserPasswordButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.editUserPasswordButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.editUserPasswordButton.Name = "editUserPasswordButton";
            this.editUserPasswordButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.editUserPasswordButton.Radius = 10;
            this.editUserPasswordButton.Size = new System.Drawing.Size(253, 68);
            this.editUserPasswordButton.TabIndex = 15;
            this.editUserPasswordButton.UseMouseOverBackColor = true;
            this.editUserPasswordButton.Click += new System.EventHandler(this.editUserPasswordButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.newUserButton.BorderColor = System.Drawing.Color.White;
            this.newUserButton.BorderWidth = 2F;
            this.newUserButton.ButtonText = "Новый пользователь";
            this.newUserButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.ForeColor = System.Drawing.Color.White;
            this.newUserButton.Location = new System.Drawing.Point(323, 27);
            this.newUserButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.newUserButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.newUserButton.Radius = 10;
            this.newUserButton.Size = new System.Drawing.Size(253, 68);
            this.newUserButton.TabIndex = 12;
            this.newUserButton.UseMouseOverBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userLoginLabel.Location = new System.Drawing.Point(13, 264);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new System.Drawing.Size(56, 18);
            userLoginLabel.TabIndex = 16;
            userLoginLabel.Text = "Логин:";
            // 
            // userLoginLabel1
            // 
            this.userLoginLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authBindingSource, "userLogin", true));
            this.userLoginLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel1.Location = new System.Drawing.Point(78, 264);
            this.userLoginLabel1.Name = "userLoginLabel1";
            this.userLoginLabel1.Size = new System.Drawing.Size(100, 23);
            this.userLoginLabel1.TabIndex = 17;
            this.userLoginLabel1.Text = "label2";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.deleteUserButton.BorderColor = System.Drawing.Color.White;
            this.deleteUserButton.BorderWidth = 2F;
            this.deleteUserButton.ButtonText = "Удалить";
            this.deleteUserButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(6, 292);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteUserButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteUserButton.Radius = 10;
            this.deleteUserButton.Size = new System.Drawing.Size(172, 68);
            this.deleteUserButton.TabIndex = 18;
            this.deleteUserButton.UseMouseOverBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 367);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(userLoginLabel);
            this.Controls.Add(this.userLoginLabel1);
            this.Controls.Add(this.editUserRoleButton);
            this.Controls.Add(this.editUserPasswordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authDataGridView);
            this.Controls.Add(this.newUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagementForm";
            this.Text = "Управление пользователями";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton newUserButton;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource authBindingSource;
        private БД_ТелестудииDataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView authDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private RoundButton editUserPasswordButton;
        private RoundButton editUserRoleButton;
        private System.Windows.Forms.Label userLoginLabel1;
        private RoundButton deleteUserButton;
    }
}