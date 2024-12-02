namespace БД_Телестудии
{
    partial class VideomaterialsForm
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
            System.Windows.Forms.Label iD_VideomaterialLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.videomaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.RadioButton();
            this.ascButton = new System.Windows.Forms.RadioButton();
            this.fieldTextBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openProgressButton = new БД_Телестудии.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ideaDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.findByDescriptionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.creation_StageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creation_StageTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Creation_StageTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_StageDataGridView = new System.Windows.Forms.DataGridView();
            this.iD_VideomaterialLabel1 = new System.Windows.Forms.Label();
            iD_VideomaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_VideomaterialLabel
            // 
            iD_VideomaterialLabel.AutoSize = true;
            iD_VideomaterialLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_VideomaterialLabel.Location = new System.Drawing.Point(798, 236);
            iD_VideomaterialLabel.Name = "iD_VideomaterialLabel";
            iD_VideomaterialLabel.Size = new System.Drawing.Size(202, 18);
            iD_VideomaterialLabel.TabIndex = 15;
            iD_VideomaterialLabel.Text = "Номер выбранного видео:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список видеоматериалов";
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BroadcastTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Creation_StageTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Video_EditingTableAdapter = null;
            this.tableAdapterManager.Videomaterial_UsageTableAdapter = null;
            this.tableAdapterManager.VideomaterialTableAdapter = this.videomaterialTableAdapter;
            // 
            // videomaterialDataGridView
            // 
            this.videomaterialDataGridView.AllowUserToAddRows = false;
            this.videomaterialDataGridView.AllowUserToDeleteRows = false;
            this.videomaterialDataGridView.AutoGenerateColumns = false;
            this.videomaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videomaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.videomaterialDataGridView.DataSource = this.videomaterialBindingSource;
            this.videomaterialDataGridView.Location = new System.Drawing.Point(16, 34);
            this.videomaterialDataGridView.Name = "videomaterialDataGridView";
            this.videomaterialDataGridView.ReadOnly = true;
            this.videomaterialDataGridView.Size = new System.Drawing.Size(543, 304);
            this.videomaterialDataGridView.TabIndex = 5;
            this.videomaterialDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videomaterialDataGridView_CellClick_1);
            this.videomaterialDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videomaterialDataGridView_CellContentClick);
            this.videomaterialDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videomaterialDataGridView_CellContentDoubleClick);
            this.videomaterialDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.videomaterialDataGridView_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Idea_description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 360;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Upload_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата загрузки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.descButton);
            this.groupBox1.Controls.Add(this.ascButton);
            this.groupBox1.Controls.Add(this.fieldTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(580, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(6, 184);
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
            this.descButton.Location = new System.Drawing.Point(6, 155);
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
            this.ascButton.Location = new System.Drawing.Point(6, 123);
            this.ascButton.Name = "ascButton";
            this.ascButton.Size = new System.Drawing.Size(170, 17);
            this.ascButton.TabIndex = 2;
            this.ascButton.TabStop = true;
            this.ascButton.Text = "Сортировка по возрастанию";
            this.ascButton.UseVisualStyleBackColor = true;
            // 
            // fieldTextBox
            // 
            this.fieldTextBox.FormattingEnabled = true;
            this.fieldTextBox.Items.AddRange(new object[] {
            "Описание",
            "Дата загрузки"});
            this.fieldTextBox.Location = new System.Drawing.Point(6, 51);
            this.fieldTextBox.Name = "fieldTextBox";
            this.fieldTextBox.Size = new System.Drawing.Size(193, 56);
            this.fieldTextBox.TabIndex = 1;
            this.fieldTextBox.SelectedIndexChanged += new System.EventHandler(this.fieldTextBox_SelectedIndexChanged);
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
            // openProgressButton
            // 
            this.openProgressButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openProgressButton.BorderColor = System.Drawing.Color.White;
            this.openProgressButton.BorderWidth = 2F;
            this.openProgressButton.ButtonText = "Прогресс монтажа";
            this.openProgressButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProgressButton.ForeColor = System.Drawing.Color.White;
            this.openProgressButton.Location = new System.Drawing.Point(571, 307);
            this.openProgressButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.openProgressButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.openProgressButton.Name = "openProgressButton";
            this.openProgressButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.openProgressButton.Radius = 10;
            this.openProgressButton.Size = new System.Drawing.Size(222, 66);
            this.openProgressButton.TabIndex = 11;
            this.openProgressButton.UseMouseOverBackColor = true;
            this.openProgressButton.Click += new System.EventHandler(this.openProgressButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Описание:";
            // 
            // ideaDescriptionTextBox
            // 
            this.ideaDescriptionTextBox.Location = new System.Drawing.Point(114, 344);
            this.ideaDescriptionTextBox.MaxLength = 400;
            this.ideaDescriptionTextBox.Name = "ideaDescriptionTextBox";
            this.ideaDescriptionTextBox.Size = new System.Drawing.Size(445, 20);
            this.ideaDescriptionTextBox.TabIndex = 13;
            // 
            // findByDescriptionButton
            // 
            this.findByDescriptionButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByDescriptionButton.Location = new System.Drawing.Point(580, 270);
            this.findByDescriptionButton.Name = "findByDescriptionButton";
            this.findByDescriptionButton.Size = new System.Drawing.Size(84, 30);
            this.findByDescriptionButton.TabIndex = 5;
            this.findByDescriptionButton.Text = "Найти";
            this.findByDescriptionButton.UseVisualStyleBackColor = true;
            this.findByDescriptionButton.Click += new System.EventHandler(this.findByDescriptionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(670, 270);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 30);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Показать все";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // creation_StageBindingSource
            // 
            this.creation_StageBindingSource.DataMember = "Creation_Stage";
            this.creation_StageBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // creation_StageTableAdapter
            // 
            this.creation_StageTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Этапы создания видеоматериала";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stage_description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание этапа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 255;
            // 
            // creation_StageDataGridView
            // 
            this.creation_StageDataGridView.AllowUserToAddRows = false;
            this.creation_StageDataGridView.AllowUserToDeleteRows = false;
            this.creation_StageDataGridView.AutoGenerateColumns = false;
            this.creation_StageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creation_StageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.creation_StageDataGridView.DataSource = this.creation_StageBindingSource;
            this.creation_StageDataGridView.Location = new System.Drawing.Point(801, 43);
            this.creation_StageDataGridView.Name = "creation_StageDataGridView";
            this.creation_StageDataGridView.ReadOnly = true;
            this.creation_StageDataGridView.Size = new System.Drawing.Size(298, 178);
            this.creation_StageDataGridView.TabIndex = 14;
            // 
            // iD_VideomaterialLabel1
            // 
            this.iD_VideomaterialLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videomaterialBindingSource, "ID_Videomaterial", true));
            this.iD_VideomaterialLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_VideomaterialLabel1.Location = new System.Drawing.Point(1007, 236);
            this.iD_VideomaterialLabel1.Name = "iD_VideomaterialLabel1";
            this.iD_VideomaterialLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_VideomaterialLabel1.TabIndex = 16;
            this.iD_VideomaterialLabel1.Text = "label5";
            // 
            // VideomaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 393);
            this.Controls.Add(iD_VideomaterialLabel);
            this.Controls.Add(this.iD_VideomaterialLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creation_StageDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findByDescriptionButton);
            this.Controls.Add(this.ideaDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openProgressButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.videomaterialDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideomaterialsForm";
            this.Text = "Видеоматериалы";
            this.Load += new System.EventHandler(this.VideomaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView videomaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private RoundButton openProgressButton;
        private System.Windows.Forms.RadioButton descButton;
        private System.Windows.Forms.RadioButton ascButton;
        private System.Windows.Forms.ListBox fieldTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ideaDescriptionTextBox;
        private System.Windows.Forms.Button findByDescriptionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource creation_StageBindingSource;
        private БД_ТелестудииDataSetTableAdapters.Creation_StageTableAdapter creation_StageTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView creation_StageDataGridView;
        private System.Windows.Forms.Label iD_VideomaterialLabel1;
    }
}