namespace БД_Телестудии
{
    partial class Manager_BroadcastPlaybackPlanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.RadioButton();
            this.ascButton = new System.Windows.Forms.RadioButton();
            this.fieldListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.broadcastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.manager_BroadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manager_BroadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Manager_BroadcastsPlaybackPlanTableAdapter();
            this.manager_BroadcastsPlaybackPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_BroadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_BroadcastsPlaybackPlanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "План воспроизведения трансляций";
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.descButton);
            this.groupBox1.Controls.Add(this.ascButton);
            this.groupBox1.Controls.Add(this.fieldListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(562, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 272);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(6, 236);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(193, 30);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // descButton
            // 
            this.descButton.AutoSize = true;
            this.descButton.Location = new System.Drawing.Point(6, 195);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(154, 17);
            this.descButton.TabIndex = 3;
            this.descButton.Text = "Сортировка по убыванию";
            this.descButton.UseVisualStyleBackColor = true;
            // 
            // ascButton
            // 
            this.ascButton.AutoSize = true;
            this.ascButton.Checked = true;
            this.ascButton.Location = new System.Drawing.Point(6, 163);
            this.ascButton.Name = "ascButton";
            this.ascButton.Size = new System.Drawing.Size(170, 17);
            this.ascButton.TabIndex = 2;
            this.ascButton.TabStop = true;
            this.ascButton.Text = "Сортировка по возрастанию";
            this.ascButton.UseVisualStyleBackColor = true;
            // 
            // fieldListBox
            // 
            this.fieldListBox.FormattingEnabled = true;
            this.fieldListBox.Items.AddRange(new object[] {
            "ID",
            "Категория",
            "Внешний канал",
            "Дата воспроизведения"});
            this.fieldListBox.Location = new System.Drawing.Point(6, 51);
            this.fieldListBox.Name = "fieldListBox";
            this.fieldListBox.Size = new System.Drawing.Size(193, 95);
            this.fieldListBox.TabIndex = 1;
            this.fieldListBox.SelectedIndexChanged += new System.EventHandler(this.fieldListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поле";
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(146, 289);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(223, 20);
            this.channelTextBox.TabIndex = 22;
            this.channelTextBox.TextChanged += new System.EventHandler(this.channelTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Внешний канал:";
            // 
            // broadcastBindingSource
            // 
            this.broadcastBindingSource.DataMember = "Broadcast";
            this.broadcastBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // broadcastTableAdapter
            // 
            this.broadcastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = this.broadcastTableAdapter;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // manager_BroadcastsPlaybackPlanBindingSource
            // 
            this.manager_BroadcastsPlaybackPlanBindingSource.DataMember = "Manager_BroadcastsPlaybackPlan";
            this.manager_BroadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // manager_BroadcastsPlaybackPlanTableAdapter
            // 
            this.manager_BroadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // manager_BroadcastsPlaybackPlanDataGridView
            // 
            this.manager_BroadcastsPlaybackPlanDataGridView.AutoGenerateColumns = false;
            this.manager_BroadcastsPlaybackPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manager_BroadcastsPlaybackPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.manager_BroadcastsPlaybackPlanDataGridView.DataSource = this.manager_BroadcastsPlaybackPlanBindingSource;
            this.manager_BroadcastsPlaybackPlanDataGridView.Location = new System.Drawing.Point(12, 40);
            this.manager_BroadcastsPlaybackPlanDataGridView.Name = "manager_BroadcastsPlaybackPlanDataGridView";
            this.manager_BroadcastsPlaybackPlanDataGridView.ReadOnly = true;
            this.manager_BroadcastsPlaybackPlanDataGridView.Size = new System.Drawing.Size(533, 223);
            this.manager_BroadcastsPlaybackPlanDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn3.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Внешний канал";
            this.dataGridViewTextBoxColumn4.HeaderText = "Внешний канал";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // Manager_BroadcastPlaybackPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 332);
            this.Controls.Add(this.manager_BroadcastsPlaybackPlanDataGridView);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager_BroadcastPlaybackPlanForm";
            this.Text = "Трансляции";
            this.Load += new System.EventHandler(this.Manager_BroadcastPlaybackPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_BroadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manager_BroadcastsPlaybackPlanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton descButton;
        private System.Windows.Forms.RadioButton ascButton;
        private System.Windows.Forms.ListBox fieldListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource broadcastBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastTableAdapter broadcastTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource manager_BroadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.Manager_BroadcastsPlaybackPlanTableAdapter manager_BroadcastsPlaybackPlanTableAdapter;
        private System.Windows.Forms.DataGridView manager_BroadcastsPlaybackPlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}