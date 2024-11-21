namespace БД_Телестудии
{
    partial class EditEvent
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.recSourceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.transitionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.videoComboBox = new System.Windows.Forms.ComboBox();
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editEventButton = new БД_Телестудии.RoundButton();
            this.transitionDurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.transitionDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.ChangeEventCommand = new System.Data.SqlClient.SqlCommand();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.GetEventInfoCommand = new System.Data.SqlClient.SqlCommand();
            this.UpdateVideoEditingSumDurationCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDurationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(31, 463);
            this.descriptionTextBox.MaxLength = 125;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(183, 26);
            this.descriptionTextBox.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Описание";
            // 
            // recSourceTextBox
            // 
            this.recSourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recSourceTextBox.Location = new System.Drawing.Point(220, 463);
            this.recSourceTextBox.MaxLength = 35;
            this.recSourceTextBox.Name = "recSourceTextBox";
            this.recSourceTextBox.Size = new System.Drawing.Size(166, 26);
            this.recSourceTextBox.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Источник записи";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "Дополнительно";
            // 
            // transitionTypeComboBox
            // 
            this.transitionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transitionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionTypeComboBox.FormattingEnabled = true;
            this.transitionTypeComboBox.Items.AddRange(new object[] {
            "Мягкий",
            "Затемнение",
            "Скачок",
            "Склейка встык",
            "Нет"});
            this.transitionTypeComboBox.Location = new System.Drawing.Point(31, 332);
            this.transitionTypeComboBox.Name = "transitionTypeComboBox";
            this.transitionTypeComboBox.Size = new System.Drawing.Size(159, 28);
            this.transitionTypeComboBox.TabIndex = 45;
            this.transitionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.transitionTypeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Длительность (сек)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Вид перехода";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Переход";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Видеоматериал";
            // 
            // videoComboBox
            // 
            this.videoComboBox.DataSource = this.broadcastsPlaybackPlanBindingSource;
            this.videoComboBox.DisplayMember = "Трансляция";
            this.videoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoComboBox.FormattingEnabled = true;
            this.videoComboBox.Location = new System.Drawing.Point(26, 52);
            this.videoComboBox.Name = "videoComboBox";
            this.videoComboBox.Size = new System.Drawing.Size(529, 24);
            this.videoComboBox.TabIndex = 39;
            this.videoComboBox.ValueMember = "Трансляция";
            // 
            // broadcastsPlaybackPlanBindingSource
            // 
            this.broadcastsPlaybackPlanBindingSource.DataMember = "BroadcastsPlaybackPlan";
            this.broadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm:ss";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(26, 188);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(100, 26);
            this.startTimePicker.TabIndex = 36;
            this.startTimePicker.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Длительность (сек)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Задержка (сек)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Время начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Выбор времени";
            // 
            // editEventButton
            // 
            this.editEventButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.editEventButton.BorderColor = System.Drawing.Color.White;
            this.editEventButton.BorderWidth = 2F;
            this.editEventButton.ButtonText = "Изменить";
            this.editEventButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventButton.ForeColor = System.Drawing.Color.White;
            this.editEventButton.Location = new System.Drawing.Point(452, 425);
            this.editEventButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editEventButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.editEventButton.Radius = 10;
            this.editEventButton.Size = new System.Drawing.Size(238, 72);
            this.editEventButton.TabIndex = 51;
            this.editEventButton.UseMouseOverBackColor = true;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // transitionDurationUpDown
            // 
            this.transitionDurationUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionDurationUpDown.Location = new System.Drawing.Point(219, 334);
            this.transitionDurationUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.transitionDurationUpDown.Name = "transitionDurationUpDown";
            this.transitionDurationUpDown.Size = new System.Drawing.Size(120, 26);
            this.transitionDurationUpDown.TabIndex = 52;
            // 
            // transitionDelayUpDown
            // 
            this.transitionDelayUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionDelayUpDown.Location = new System.Drawing.Point(402, 334);
            this.transitionDelayUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.transitionDelayUpDown.Name = "transitionDelayUpDown";
            this.transitionDelayUpDown.Size = new System.Drawing.Size(120, 26);
            this.transitionDelayUpDown.TabIndex = 53;
            // 
            // durationUpDown
            // 
            this.durationUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUpDown.Location = new System.Drawing.Point(219, 188);
            this.durationUpDown.Maximum = new decimal(new int[] {
            864000,
            0,
            0,
            0});
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(120, 26);
            this.durationUpDown.TabIndex = 54;
            // 
            // broadcastsPlaybackPlanTableAdapter
            // 
            this.broadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ChangeEventCommand
            // 
            this.ChangeEventCommand.CommandText = "ChangeEvent";
            this.ChangeEventCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ChangeEventCommand.Connection = this.sqlConnection1;
            this.ChangeEventCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@eventID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@startTime", System.Data.SqlDbType.Time),
            new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@transitionType", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@transitionDuration", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@transitionDelay", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@recSource", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@videoTitle", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@editingID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
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
            // GetEventInfoCommand
            // 
            this.GetEventInfoCommand.CommandText = "GetEventInfo";
            this.GetEventInfoCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.GetEventInfoCommand.Connection = this.sqlConnection1;
            this.GetEventInfoCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@eventID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@startTime", System.Data.SqlDbType.Time, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@transitionType", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@transitionDuration", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@transitionDelay", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar, 125, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@recSource", System.Data.SqlDbType.VarChar, 35, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // UpdateVideoEditingSumDurationCommand
            // 
            this.UpdateVideoEditingSumDurationCommand.CommandText = "UpdateVideoEditingSumDuration";
            this.UpdateVideoEditingSumDurationCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.UpdateVideoEditingSumDurationCommand.Connection = this.sqlConnection1;
            this.UpdateVideoEditingSumDurationCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@broadcastID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@eventID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@editingID", System.Data.SqlDbType.Int)});
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 517);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.transitionDelayUpDown);
            this.Controls.Add(this.transitionDurationUpDown);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.recSourceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.transitionTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.videoComboBox);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEvent";
            this.Text = "Изменение события";
            this.Load += new System.EventHandler(this.EditEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDurationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton editEventButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox recSourceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox transitionTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox videoComboBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown transitionDurationUpDown;
        private System.Windows.Forms.NumericUpDown transitionDelayUpDown;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand ChangeEventCommand;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private БД_ТелестудииDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Data.SqlClient.SqlCommand GetEventInfoCommand;
        private System.Data.SqlClient.SqlCommand UpdateVideoEditingSumDurationCommand;
    }
}