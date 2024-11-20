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
            this.detailedTableCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.broadcastsPlaybackPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcastsPlaybackPlan_DetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastsPlaybackPlan_DetailedTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlan_DetailedTableAdapter();
            this.broadcastsPlaybackPlan_DetailedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.RadioButton();
            this.ascButton = new System.Windows.Forms.RadioButton();
            this.fieldListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.findByDescriptionButton = new System.Windows.Forms.Button();
            this.ideaDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detailedFieldListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailedTableCheckBox
            // 
            this.detailedTableCheckBox.AutoSize = true;
            this.detailedTableCheckBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedTableCheckBox.Location = new System.Drawing.Point(594, 10);
            this.detailedTableCheckBox.Name = "detailedTableCheckBox";
            this.detailedTableCheckBox.Size = new System.Drawing.Size(194, 22);
            this.detailedTableCheckBox.TabIndex = 17;
            this.detailedTableCheckBox.Text = "Подробное отображение";
            this.detailedTableCheckBox.UseVisualStyleBackColor = true;
            this.detailedTableCheckBox.CheckedChanged += new System.EventHandler(this.detailedTableCheckBox_CheckedChanged);
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
            // broadcastsPlaybackPlanBindingSource
            // 
            this.broadcastsPlaybackPlanBindingSource.DataMember = "BroadcastsPlaybackPlan";
            this.broadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // broadcastsPlaybackPlanTableAdapter
            // 
            this.broadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = null;
            // 
            // broadcastsPlaybackPlanDataGridView
            // 
            this.broadcastsPlaybackPlanDataGridView.AutoGenerateColumns = false;
            this.broadcastsPlaybackPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.broadcastsPlaybackPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.broadcastsPlaybackPlanDataGridView.DataSource = this.broadcastsPlaybackPlanBindingSource;
            this.broadcastsPlaybackPlanDataGridView.Location = new System.Drawing.Point(12, 48);
            this.broadcastsPlaybackPlanDataGridView.Name = "broadcastsPlaybackPlanDataGridView";
            this.broadcastsPlaybackPlanDataGridView.ReadOnly = true;
            this.broadcastsPlaybackPlanDataGridView.Size = new System.Drawing.Size(776, 258);
            this.broadcastsPlaybackPlanDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Внешний канал";
            this.dataGridViewTextBoxColumn3.HeaderText = "Внешний канал";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Трансляция";
            this.dataGridViewTextBoxColumn1.HeaderText = "Трансляция";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 360;
            // 
            // broadcastsPlaybackPlan_DetailedBindingSource
            // 
            this.broadcastsPlaybackPlan_DetailedBindingSource.DataMember = "BroadcastsPlaybackPlan_Detailed";
            this.broadcastsPlaybackPlan_DetailedBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // broadcastsPlaybackPlan_DetailedTableAdapter
            // 
            this.broadcastsPlaybackPlan_DetailedTableAdapter.ClearBeforeFill = true;
            // 
            // broadcastsPlaybackPlan_DetailedDataGridView
            // 
            this.broadcastsPlaybackPlan_DetailedDataGridView.AutoGenerateColumns = false;
            this.broadcastsPlaybackPlan_DetailedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.broadcastsPlaybackPlan_DetailedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.broadcastsPlaybackPlan_DetailedDataGridView.DataSource = this.broadcastsPlaybackPlan_DetailedBindingSource;
            this.broadcastsPlaybackPlan_DetailedDataGridView.Location = new System.Drawing.Point(12, 48);
            this.broadcastsPlaybackPlan_DetailedDataGridView.Name = "broadcastsPlaybackPlan_DetailedDataGridView";
            this.broadcastsPlaybackPlan_DetailedDataGridView.ReadOnly = true;
            this.broadcastsPlaybackPlan_DetailedDataGridView.Size = new System.Drawing.Size(776, 258);
            this.broadcastsPlaybackPlan_DetailedDataGridView.TabIndex = 18;
            this.broadcastsPlaybackPlan_DetailedDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Трансляция";
            this.dataGridViewTextBoxColumn5.HeaderText = "Трансляция";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 360;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn6.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Внешний канал";
            this.dataGridViewTextBoxColumn7.HeaderText = "Внешний канал";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 160;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Длительность";
            this.dataGridViewTextBoxColumn9.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 160;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Частота кадров";
            this.dataGridViewTextBoxColumn10.HeaderText = "Частота кадров";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 170;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn11.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailedFieldListBox);
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.descButton);
            this.groupBox1.Controls.Add(this.ascButton);
            this.groupBox1.Controls.Add(this.fieldListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(794, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 264);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(6, 228);
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
            "Трансляция",
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
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(884, 324);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 30);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Показать все";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // findByDescriptionButton
            // 
            this.findByDescriptionButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByDescriptionButton.Location = new System.Drawing.Point(794, 324);
            this.findByDescriptionButton.Name = "findByDescriptionButton";
            this.findByDescriptionButton.Size = new System.Drawing.Size(84, 30);
            this.findByDescriptionButton.TabIndex = 20;
            this.findByDescriptionButton.Text = "Найти";
            this.findByDescriptionButton.UseVisualStyleBackColor = true;
            this.findByDescriptionButton.Click += new System.EventHandler(this.findByDescriptionButton_Click);
            // 
            // ideaDescriptionTextBox
            // 
            this.ideaDescriptionTextBox.Location = new System.Drawing.Point(119, 331);
            this.ideaDescriptionTextBox.Name = "ideaDescriptionTextBox";
            this.ideaDescriptionTextBox.Size = new System.Drawing.Size(562, 20);
            this.ideaDescriptionTextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Трансляция:";
            // 
            // detailedFieldListBox
            // 
            this.detailedFieldListBox.FormattingEnabled = true;
            this.detailedFieldListBox.Items.AddRange(new object[] {
            "Трансляция",
            "Категория",
            "Внешний канал",
            "Дата воспроизведения",
            "Длительность",
            "Автор"});
            this.detailedFieldListBox.Location = new System.Drawing.Point(7, 51);
            this.detailedFieldListBox.Name = "detailedFieldListBox";
            this.detailedFieldListBox.Size = new System.Drawing.Size(193, 95);
            this.detailedFieldListBox.TabIndex = 5;
            this.detailedFieldListBox.Visible = false;
            this.detailedFieldListBox.SelectedIndexChanged += new System.EventHandler(this.detailedFieldListBox_SelectedIndexChanged);
            // 
            // Manager_BroadcastPlaybackPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 374);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findByDescriptionButton);
            this.Controls.Add(this.ideaDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.broadcastsPlaybackPlan_DetailedDataGridView);
            this.Controls.Add(this.broadcastsPlaybackPlanDataGridView);
            this.Controls.Add(this.detailedTableCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Manager_BroadcastPlaybackPlanForm";
            this.Text = "Трансляции";
            this.Load += new System.EventHandler(this.Manager_BroadcastPlaybackPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox detailedTableCheckBox;
        private System.Windows.Forms.Label label1;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView broadcastsPlaybackPlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlan_DetailedBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlan_DetailedTableAdapter broadcastsPlaybackPlan_DetailedTableAdapter;
        private System.Windows.Forms.DataGridView broadcastsPlaybackPlan_DetailedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton descButton;
        private System.Windows.Forms.RadioButton ascButton;
        private System.Windows.Forms.ListBox fieldListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button findByDescriptionButton;
        private System.Windows.Forms.TextBox ideaDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox detailedFieldListBox;
    }
}