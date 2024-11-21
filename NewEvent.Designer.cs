namespace БД_Телестудии
{
    partial class NewEvent
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
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.addEventButton = new БД_Телестудии.RoundButton();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.transitionDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.transitionDurationUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.AddNewEventCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDurationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // broadcastsPlaybackPlanBindingSource
            // 
            this.broadcastsPlaybackPlanBindingSource.DataMember = "BroadcastsPlaybackPlan";
            this.broadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // broadcastsPlaybackPlanTableAdapter
            // 
            this.broadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // videomaterialBindingSource
            // 
            this.videomaterialBindingSource.DataMember = "Videomaterial";
            this.videomaterialBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // videomaterialTableAdapter
            // 
            this.videomaterialTableAdapter.ClearBeforeFill = true;
            // 
            // addEventButton
            // 
            this.addEventButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.addEventButton.BorderColor = System.Drawing.Color.White;
            this.addEventButton.BorderWidth = 2F;
            this.addEventButton.ButtonText = "Добавить";
            this.addEventButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.ForeColor = System.Drawing.Color.White;
            this.addEventButton.Location = new System.Drawing.Point(454, 430);
            this.addEventButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addEventButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.addEventButton.Radius = 10;
            this.addEventButton.Size = new System.Drawing.Size(238, 72);
            this.addEventButton.TabIndex = 31;
            this.addEventButton.UseMouseOverBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // durationUpDown
            // 
            this.durationUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUpDown.Location = new System.Drawing.Point(217, 190);
            this.durationUpDown.Maximum = new decimal(new int[] {
            864000,
            0,
            0,
            0});
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(120, 26);
            this.durationUpDown.TabIndex = 73;
            // 
            // transitionDelayUpDown
            // 
            this.transitionDelayUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionDelayUpDown.Location = new System.Drawing.Point(400, 336);
            this.transitionDelayUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.transitionDelayUpDown.Name = "transitionDelayUpDown";
            this.transitionDelayUpDown.Size = new System.Drawing.Size(120, 26);
            this.transitionDelayUpDown.TabIndex = 72;
            // 
            // transitionDurationUpDown
            // 
            this.transitionDurationUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transitionDurationUpDown.Location = new System.Drawing.Point(217, 336);
            this.transitionDurationUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.transitionDurationUpDown.Name = "transitionDurationUpDown";
            this.transitionDurationUpDown.Size = new System.Drawing.Size(120, 26);
            this.transitionDurationUpDown.TabIndex = 71;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(29, 465);
            this.descriptionTextBox.MaxLength = 125;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(183, 26);
            this.descriptionTextBox.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "Описание";
            // 
            // recSourceTextBox
            // 
            this.recSourceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recSourceTextBox.Location = new System.Drawing.Point(218, 465);
            this.recSourceTextBox.MaxLength = 35;
            this.recSourceTextBox.Name = "recSourceTextBox";
            this.recSourceTextBox.Size = new System.Drawing.Size(166, 26);
            this.recSourceTextBox.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 67;
            this.label7.Text = "Источник записи";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 22);
            this.label11.TabIndex = 66;
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
            this.transitionTypeComboBox.Location = new System.Drawing.Point(29, 334);
            this.transitionTypeComboBox.Name = "transitionTypeComboBox";
            this.transitionTypeComboBox.Size = new System.Drawing.Size(159, 28);
            this.transitionTypeComboBox.TabIndex = 65;
            this.transitionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.transitionTypeComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Длительность (сек)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 63;
            this.label8.Text = "Вид перехода";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 62;
            this.label9.Text = "Переход";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 61;
            this.label6.Text = "Видеоматериал";
            // 
            // videoComboBox
            // 
            this.videoComboBox.DataSource = this.broadcastsPlaybackPlanBindingSource;
            this.videoComboBox.DisplayMember = "Трансляция";
            this.videoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoComboBox.FormattingEnabled = true;
            this.videoComboBox.Location = new System.Drawing.Point(24, 54);
            this.videoComboBox.Name = "videoComboBox";
            this.videoComboBox.Size = new System.Drawing.Size(529, 24);
            this.videoComboBox.TabIndex = 60;
            this.videoComboBox.ValueMember = "Трансляция";
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "hh:mm:ss";
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(24, 190);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(100, 26);
            this.startTimePicker.TabIndex = 59;
            this.startTimePicker.Value = new System.DateTime(2024, 11, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Длительность (сек)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Задержка (сек)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Время начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Выбор времени";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // AddNewEventCommand
            // 
            this.AddNewEventCommand.CommandText = "AddNewEvent";
            this.AddNewEventCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.AddNewEventCommand.Connection = this.sqlConnection1;
            this.AddNewEventCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@broadcastID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@videoID", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@startTime", System.Data.SqlDbType.Time),
            new System.Data.SqlClient.SqlParameter("@duration", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@transitionType", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@transitionDuration", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@transitionDelay", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@description", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@recSource", System.Data.SqlDbType.VarChar)});
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 505);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.transitionDelayUpDown);
            this.Controls.Add(this.transitionDurationUpDown);
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
            this.Controls.Add(this.addEventButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEvent";
            this.Text = "Создание события";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitionDurationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private RoundButton addEventButton;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.NumericUpDown transitionDelayUpDown;
        private System.Windows.Forms.NumericUpDown transitionDurationUpDown;
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
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand AddNewEventCommand;
    }
}