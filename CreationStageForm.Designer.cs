namespace БД_Телестудии
{
    partial class CreationStageForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.videoComboBox = new System.Windows.Forms.ComboBox();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.creation_StageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creation_StageDataGridView = new System.Windows.Forms.DataGridView();
            this.creation_StageTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Creation_StageTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.addStageCommand = new System.Data.SqlClient.SqlCommand();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addStageButton = new БД_Телестудии.RoundButton();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stage_descriptionLabel1 = new System.Windows.Forms.Label();
            this.deleteBut = new БД_Телестудии.RoundButton();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Видеоматериал";
            // 
            // videoComboBox
            // 
            this.videoComboBox.DataSource = this.videomaterialBindingSource;
            this.videoComboBox.DisplayMember = "Idea_description";
            this.videoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoComboBox.FormattingEnabled = true;
            this.videoComboBox.Location = new System.Drawing.Point(12, 49);
            this.videoComboBox.Name = "videoComboBox";
            this.videoComboBox.Size = new System.Drawing.Size(486, 24);
            this.videoComboBox.TabIndex = 15;
            this.videoComboBox.ValueMember = "Idea_description";
            this.videoComboBox.SelectedIndexChanged += new System.EventHandler(this.videoComboBox_SelectedIndexChanged);
            // 
            // videomaterialBindingSource
            // 
            this.videomaterialBindingSource.DataMember = "Videomaterial";
            this.videomaterialBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creation_StageBindingSource
            // 
            this.creation_StageBindingSource.DataMember = "Creation_Stage";
            this.creation_StageBindingSource.DataSource = this.бД_ТелестудииDataSet;
            this.creation_StageBindingSource.Filter = "ID_Videomaterial=1";
            // 
            // creation_StageDataGridView
            // 
            this.creation_StageDataGridView.AllowUserToAddRows = false;
            this.creation_StageDataGridView.AllowUserToDeleteRows = false;
            this.creation_StageDataGridView.AutoGenerateColumns = false;
            this.creation_StageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creation_StageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.creation_StageDataGridView.DataSource = this.creation_StageBindingSource;
            this.creation_StageDataGridView.Location = new System.Drawing.Point(12, 90);
            this.creation_StageDataGridView.Name = "creation_StageDataGridView";
            this.creation_StageDataGridView.ReadOnly = true;
            this.creation_StageDataGridView.Size = new System.Drawing.Size(776, 189);
            this.creation_StageDataGridView.TabIndex = 17;
            // 
            // creation_StageTableAdapter
            // 
            this.creation_StageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Creation_StageTableAdapter = this.creation_StageTableAdapter;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // videomaterialTableAdapter
            // 
            this.videomaterialTableAdapter.ClearBeforeFill = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // addStageCommand
            // 
            this.addStageCommand.CommandText = "AddStage";
            this.addStageCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.addStageCommand.Connection = this.sqlConnection1;
            this.addStageCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@stage_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@video_id", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@desc", System.Data.SqlDbType.VarChar)});
            // 
            // descTextBox
            // 
            this.descTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTextBox.Location = new System.Drawing.Point(12, 323);
            this.descTextBox.MaxLength = 300;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(685, 29);
            this.descTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Описание этапа";
            // 
            // addStageButton
            // 
            this.addStageButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.addStageButton.BorderColor = System.Drawing.Color.White;
            this.addStageButton.BorderWidth = 2F;
            this.addStageButton.ButtonText = "Добавить";
            this.addStageButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStageButton.ForeColor = System.Drawing.Color.White;
            this.addStageButton.Location = new System.Drawing.Point(5, 364);
            this.addStageButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addStageButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.addStageButton.Name = "addStageButton";
            this.addStageButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.addStageButton.Radius = 15;
            this.addStageButton.Size = new System.Drawing.Size(168, 72);
            this.addStageButton.TabIndex = 39;
            this.addStageButton.UseMouseOverBackColor = true;
            this.addStageButton.Click += new System.EventHandler(this.addStageButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(677, 570);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 23);
            this.logOutButton.TabIndex = 55;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Этап для удаления";
            // 
            // stage_descriptionLabel1
            // 
            this.stage_descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creation_StageBindingSource, "Stage_description", true));
            this.stage_descriptionLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stage_descriptionLabel1.Location = new System.Drawing.Point(10, 463);
            this.stage_descriptionLabel1.Name = "stage_descriptionLabel1";
            this.stage_descriptionLabel1.Size = new System.Drawing.Size(778, 51);
            this.stage_descriptionLabel1.TabIndex = 57;
            this.stage_descriptionLabel1.Text = "label4";
            // 
            // deleteBut
            // 
            this.deleteBut.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.deleteBut.BorderColor = System.Drawing.Color.White;
            this.deleteBut.BorderWidth = 2F;
            this.deleteBut.ButtonText = "Удалить";
            this.deleteBut.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBut.ForeColor = System.Drawing.Color.White;
            this.deleteBut.Location = new System.Drawing.Point(5, 519);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deleteBut.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteBut.Radius = 15;
            this.deleteBut.Size = new System.Drawing.Size(168, 72);
            this.deleteBut.TabIndex = 58;
            this.deleteBut.UseMouseOverBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stage_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание этапа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 900;
            // 
            // CreationStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.stage_descriptionLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addStageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.creation_StageDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreationStageForm";
            this.Text = "Структура программы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreationStageForm_FormClosed);
            this.Load += new System.EventHandler(this.CreationStageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox videoComboBox;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource creation_StageBindingSource;
        private БД_ТелестудииDataSetTableAdapters.Creation_StageTableAdapter creation_StageTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView creation_StageDataGridView;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand addStageCommand;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label label1;
        private RoundButton addStageButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stage_descriptionLabel1;
        private RoundButton deleteBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}