namespace БД_Телестудии
{
    partial class VideoEditingForm
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
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcastTitleLabel = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.GetBroadcastAndVideoIDByTitleCommand = new System.Data.SqlClient.SqlCommand();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.eventViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventViewTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.EventViewTableAdapter();
            this.eventViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AutoGenerateColumns = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.eventDataGridView.DataSource = this.eventBindingSource;
            this.eventDataGridView.Location = new System.Drawing.Point(12, 44);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.Size = new System.Drawing.Size(896, 408);
            this.eventDataGridView.TabIndex = 17;
            this.eventDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.eventDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Start_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время начала";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Playback_duration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Transition_type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вид перехода";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Recording_source";
            this.dataGridViewTextBoxColumn7.HeaderText = "Источник записи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Transition_duration";
            this.dataGridViewTextBoxColumn8.HeaderText = "Длительность перехода";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Delay_duration";
            this.dataGridViewTextBoxColumn9.HeaderText = "Задержка";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Event_description";
            this.dataGridViewTextBoxColumn10.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 165;
            // 
            // broadcastTitleLabel
            // 
            this.broadcastTitleLabel.AutoSize = true;
            this.broadcastTitleLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broadcastTitleLabel.Location = new System.Drawing.Point(12, 8);
            this.broadcastTitleLabel.Name = "broadcastTitleLabel";
            this.broadcastTitleLabel.Size = new System.Drawing.Size(56, 18);
            this.broadcastTitleLabel.TabIndex = 18;
            this.broadcastTitleLabel.Text = "label1";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // GetBroadcastAndVideoIDByTitleCommand
            // 
            this.GetBroadcastAndVideoIDByTitleCommand.CommandText = "GetBroadcastAndVideoIDByTitle";
            this.GetBroadcastAndVideoIDByTitleCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.GetBroadcastAndVideoIDByTitleCommand.Connection = this.sqlConnection1;
            this.GetBroadcastAndVideoIDByTitleCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@video_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@broadcast_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // AddEventButton
            // 
            this.AddEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventButton.Location = new System.Drawing.Point(15, 466);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(158, 53);
            this.AddEventButton.TabIndex = 19;
            this.AddEventButton.Text = "Добавить новое событие";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // eventViewBindingSource
            // 
            this.eventViewBindingSource.DataMember = "EventView";
            this.eventViewBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // eventViewTableAdapter
            // 
            this.eventViewTableAdapter.ClearBeforeFill = true;
            // 
            // eventViewDataGridView
            // 
            this.eventViewDataGridView.AutoGenerateColumns = false;
            this.eventViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.eventViewDataGridView.DataSource = this.eventViewBindingSource;
            this.eventViewDataGridView.Location = new System.Drawing.Point(15, 362);
            this.eventViewDataGridView.Name = "eventViewDataGridView";
            this.eventViewDataGridView.ReadOnly = true;
            this.eventViewDataGridView.Size = new System.Drawing.Size(135, 90);
            this.eventViewDataGridView.TabIndex = 19;
            this.eventViewDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Event";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Event";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Start_time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Start_time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Playback_duration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Playback_duration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Transition_type";
            this.dataGridViewTextBoxColumn11.HeaderText = "Transition_type";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Recording_source";
            this.dataGridViewTextBoxColumn12.HeaderText = "Recording_source";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Transition_duration";
            this.dataGridViewTextBoxColumn13.HeaderText = "Transition_duration";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Delay_duration";
            this.dataGridViewTextBoxColumn14.HeaderText = "Delay_duration";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Event_description";
            this.dataGridViewTextBoxColumn15.HeaderText = "Event_description";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ID_Broadcast";
            this.dataGridViewTextBoxColumn16.HeaderText = "ID_Broadcast";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // VideoEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 527);
            this.Controls.Add(this.eventViewDataGridView);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.broadcastTitleLabel);
            this.Controls.Add(this.eventDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoEditingForm";
            this.Text = "Монтаж";
            this.Load += new System.EventHandler(this.VideoEditingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private БД_ТелестудииDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.Label broadcastTitleLabel;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand GetBroadcastAndVideoIDByTitleCommand;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.BindingSource eventViewBindingSource;
        private БД_ТелестудииDataSetTableAdapters.EventViewTableAdapter eventViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView eventViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}