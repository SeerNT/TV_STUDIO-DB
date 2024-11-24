namespace БД_Телестудии
{
    partial class FilmCrewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmCrewForm));
            this.DB_TVStudioDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.videomaterialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.videomaterialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.videomaterialDataGridView = new System.Windows.Forms.DataGridView();
            this.Idea_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.videoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.videoDescTextBox = new БД_Телестудии.RoundTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addVideoButton = new БД_Телестудии.RoundButton();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TVStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingNavigator)).BeginInit();
            this.videomaterialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DB_TVStudioDataSet
            // 
            this.DB_TVStudioDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.DB_TVStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videomaterialBindingSource
            // 
            this.videomaterialBindingSource.DataMember = "Videomaterial";
            this.videomaterialBindingSource.DataSource = this.DB_TVStudioDataSet;
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
            // videomaterialBindingNavigator
            // 
            this.videomaterialBindingNavigator.AddNewItem = null;
            this.videomaterialBindingNavigator.BindingSource = this.videomaterialBindingSource;
            this.videomaterialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.videomaterialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.videomaterialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.videomaterialBindingNavigatorSaveItem});
            this.videomaterialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.videomaterialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.videomaterialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.videomaterialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.videomaterialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.videomaterialBindingNavigator.Name = "videomaterialBindingNavigator";
            this.videomaterialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.videomaterialBindingNavigator.Size = new System.Drawing.Size(748, 25);
            this.videomaterialBindingNavigator.TabIndex = 0;
            this.videomaterialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // videomaterialBindingNavigatorSaveItem
            // 
            this.videomaterialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.videomaterialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("videomaterialBindingNavigatorSaveItem.Image")));
            this.videomaterialBindingNavigatorSaveItem.Name = "videomaterialBindingNavigatorSaveItem";
            this.videomaterialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.videomaterialBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.videomaterialBindingNavigatorSaveItem.Click += new System.EventHandler(this.videomaterialBindingNavigatorSaveItem_Click);
            // 
            // videomaterialDataGridView
            // 
            this.videomaterialDataGridView.AllowUserToAddRows = false;
            this.videomaterialDataGridView.AutoGenerateColumns = false;
            this.videomaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videomaterialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idea_description,
            this.dataGridViewTextBoxColumn3});
            this.videomaterialDataGridView.DataSource = this.videomaterialBindingSource;
            this.videomaterialDataGridView.Location = new System.Drawing.Point(11, 48);
            this.videomaterialDataGridView.Name = "videomaterialDataGridView";
            this.videomaterialDataGridView.Size = new System.Drawing.Size(453, 254);
            this.videomaterialDataGridView.TabIndex = 1;
            // 
            // Idea_description
            // 
            this.Idea_description.DataPropertyName = "Idea_description";
            this.Idea_description.HeaderText = "Описание";
            this.Idea_description.Name = "Idea_description";
            this.Idea_description.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Upload_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата загрузки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список видеоматериалов";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.videoDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.videoDescTextBox);
            this.groupBox1.Location = new System.Drawing.Point(480, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление видеоматериала";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата загрузки";
            // 
            // videoDateTimePicker
            // 
            this.videoDateTimePicker.Enabled = false;
            this.videoDateTimePicker.Location = new System.Drawing.Point(9, 157);
            this.videoDateTimePicker.Name = "videoDateTimePicker";
            this.videoDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.videoDateTimePicker.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание";
            // 
            // videoDescTextBox
            // 
            this.videoDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoDescTextBox.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.videoDescTextBox.BorderColor = System.Drawing.Color.White;
            this.videoDescTextBox.BorderWidth = 7F;
            this.videoDescTextBox.Enabled = false;
            this.videoDescTextBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoDescTextBox.Location = new System.Drawing.Point(-2, 45);
            this.videoDescTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.videoDescTextBox.Name = "videoDescTextBox";
            this.videoDescTextBox.Radius = 10;
            this.videoDescTextBox.Size = new System.Drawing.Size(249, 77);
            this.videoDescTextBox.TabIndex = 11;
            this.videoDescTextBox.UseSystemPasswordChar = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MKV Files (*.mkv)|*.mkv|MP4 Files (*.mp4)|*.mp4";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // addVideoButton
            // 
            this.addVideoButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.addVideoButton.BorderColor = System.Drawing.Color.White;
            this.addVideoButton.BorderWidth = 2F;
            this.addVideoButton.ButtonText = "Добавить";
            this.addVideoButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVideoButton.ForeColor = System.Drawing.Color.White;
            this.addVideoButton.Location = new System.Drawing.Point(478, 242);
            this.addVideoButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addVideoButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.addVideoButton.Radius = 10;
            this.addVideoButton.Size = new System.Drawing.Size(136, 67);
            this.addVideoButton.TabIndex = 9;
            this.addVideoButton.UseMouseOverBackColor = true;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(625, 286);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 23);
            this.logOutButton.TabIndex = 56;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // FilmCrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 320);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addVideoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videomaterialDataGridView);
            this.Controls.Add(this.videomaterialBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmCrewForm";
            this.Text = "Видеоматериалы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilmCrewForm_FormClosed);
            this.Load += new System.EventHandler(this.FilmCrewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_TVStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingNavigator)).EndInit();
            this.videomaterialBindingNavigator.ResumeLayout(false);
            this.videomaterialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public БД_ТелестудииDataSet DB_TVStudioDataSet;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator videomaterialBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton videomaterialBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView videomaterialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idea_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private RoundButton addVideoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private RoundTextBox videoDescTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker videoDateTimePicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logOutButton;
    }
}