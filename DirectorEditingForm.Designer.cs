namespace БД_Телестудии
{
    partial class DirectorEditingForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playDate = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.ChangeBroadcastCommand = new System.Data.SqlClient.SqlCommand();
            this.GetIDsCommand = new System.Data.SqlClient.SqlCommand();
            this.AddNewBroadcastCommand = new System.Data.SqlClient.SqlCommand();
            this.GetLastBroadcastIdCommand = new System.Data.SqlClient.SqlCommand();
            this.AddBaseEventCommand = new System.Data.SqlClient.SqlCommand();
            this.changeBroadcastButton = new БД_Телестудии.RoundButton();
            this.ChangeVideomaterialTitleCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(21, 52);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(348, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название трансляции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Внешний канал";
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(21, 235);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(255, 20);
            this.channelTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата воспроизведения";
            // 
            // playDate
            // 
            this.playDate.Location = new System.Drawing.Point(21, 331);
            this.playDate.Name = "playDate";
            this.playDate.Size = new System.Drawing.Size(200, 20);
            this.playDate.TabIndex = 11;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "Title", true));
            this.categoryComboBox.DataSource = this.categoryBindingSource1;
            this.categoryComboBox.DisplayMember = "Title";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(21, 144);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(138, 21);
            this.categoryComboBox.TabIndex = 13;
            this.categoryComboBox.ValueMember = "Title";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.бД_ТелестудииDataSet;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ChangeBroadcastCommand
            // 
            this.ChangeBroadcastCommand.CommandText = "ChangeBroadcast";
            this.ChangeBroadcastCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ChangeBroadcastCommand.Connection = this.sqlConnection1;
            this.ChangeBroadcastCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@video_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@broadcast_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@newTitle", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@category", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@channel", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@playDate", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // GetIDsCommand
            // 
            this.GetIDsCommand.CommandText = "GetBroadcastAndVideoIDByTitle";
            this.GetIDsCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.GetIDsCommand.Connection = this.sqlConnection1;
            this.GetIDsCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@video_id", System.Data.SqlDbType.Int, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@broadcast_id", System.Data.SqlDbType.Int, 100, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // AddNewBroadcastCommand
            // 
            this.AddNewBroadcastCommand.CommandText = "AddNewBroadcast";
            this.AddNewBroadcastCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.AddNewBroadcastCommand.Connection = this.sqlConnection1;
            this.AddNewBroadcastCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@broadcast_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@category", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@channel", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@play_date", System.Data.SqlDbType.DateTime)});
            // 
            // GetLastBroadcastIdCommand
            // 
            this.GetLastBroadcastIdCommand.CommandText = "GetLastBroadcastId";
            this.GetLastBroadcastIdCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.GetLastBroadcastIdCommand.Connection = this.sqlConnection1;
            this.GetLastBroadcastIdCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@last_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // AddBaseEventCommand
            // 
            this.AddBaseEventCommand.CommandText = "AddBaseEvent";
            this.AddBaseEventCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.AddBaseEventCommand.Connection = this.sqlConnection1;
            this.AddBaseEventCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@broadcastID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@videoTitle", System.Data.SqlDbType.VarChar)});
            // 
            // changeBroadcastButton
            // 
            this.changeBroadcastButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.changeBroadcastButton.BorderColor = System.Drawing.Color.White;
            this.changeBroadcastButton.BorderWidth = 2F;
            this.changeBroadcastButton.ButtonText = "Изменить";
            this.changeBroadcastButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBroadcastButton.ForeColor = System.Drawing.Color.White;
            this.changeBroadcastButton.Location = new System.Drawing.Point(9, 376);
            this.changeBroadcastButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.changeBroadcastButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.changeBroadcastButton.Name = "changeBroadcastButton";
            this.changeBroadcastButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.changeBroadcastButton.Radius = 10;
            this.changeBroadcastButton.Size = new System.Drawing.Size(136, 67);
            this.changeBroadcastButton.TabIndex = 12;
            this.changeBroadcastButton.UseMouseOverBackColor = true;
            this.changeBroadcastButton.Click += new System.EventHandler(this.changeBroadcastButton_Click);
            // 
            // ChangeVideomaterialTitleCommand
            // 
            this.ChangeVideomaterialTitleCommand.CommandText = "ChangeVideomaterialTitle";
            this.ChangeVideomaterialTitleCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ChangeVideomaterialTitleCommand.Connection = this.sqlConnection1;
            this.ChangeVideomaterialTitleCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@video_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@newTitle", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // DirectorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 457);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.changeBroadcastButton);
            this.Controls.Add(this.playDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorEditingForm";
            this.Text = "Настройка трансляции";
            this.Load += new System.EventHandler(this.DirectorEditingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private БД_ТелестудииDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker playDate;
        private RoundButton changeBroadcastButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand ChangeBroadcastCommand;
        private System.Data.SqlClient.SqlCommand GetIDsCommand;
        private System.Data.SqlClient.SqlCommand AddNewBroadcastCommand;
        private System.Data.SqlClient.SqlCommand GetLastBroadcastIdCommand;
        private System.Data.SqlClient.SqlCommand AddBaseEventCommand;
        private System.Data.SqlClient.SqlCommand ChangeVideomaterialTitleCommand;
    }
}