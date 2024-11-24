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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationStageForm));
            this.label2 = new System.Windows.Forms.Label();
            this.videoComboBox = new System.Windows.Forms.ComboBox();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.creation_StageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.creation_StageBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.creation_StageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.creation_StageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_StageTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Creation_StageTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.addStageCommand = new System.Data.SqlClient.SqlCommand();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addStageButton = new БД_Телестудии.RoundButton();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingNavigator)).BeginInit();
            this.creation_StageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
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
            this.videoComboBox.Location = new System.Drawing.Point(12, 80);
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
            // creation_StageBindingNavigator
            // 
            this.creation_StageBindingNavigator.AddNewItem = null;
            this.creation_StageBindingNavigator.BindingSource = this.creation_StageBindingSource;
            this.creation_StageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.creation_StageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.creation_StageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.creation_StageBindingNavigatorSaveItem});
            this.creation_StageBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.creation_StageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.creation_StageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.creation_StageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.creation_StageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.creation_StageBindingNavigator.Name = "creation_StageBindingNavigator";
            this.creation_StageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.creation_StageBindingNavigator.Size = new System.Drawing.Size(701, 25);
            this.creation_StageBindingNavigator.TabIndex = 17;
            this.creation_StageBindingNavigator.Text = "bindingNavigator1";
            // 
            // creation_StageBindingSource
            // 
            this.creation_StageBindingSource.DataMember = "Creation_Stage";
            this.creation_StageBindingSource.DataSource = this.бД_ТелестудииDataSet;
            this.creation_StageBindingSource.Filter = "ID_Videomaterial=1";
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
            // creation_StageBindingNavigatorSaveItem
            // 
            this.creation_StageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.creation_StageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("creation_StageBindingNavigatorSaveItem.Image")));
            this.creation_StageBindingNavigatorSaveItem.Name = "creation_StageBindingNavigatorSaveItem";
            this.creation_StageBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.creation_StageBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.creation_StageBindingNavigatorSaveItem.Click += new System.EventHandler(this.creation_StageBindingNavigatorSaveItem_Click);
            // 
            // creation_StageDataGridView
            // 
            this.creation_StageDataGridView.AllowUserToAddRows = false;
            this.creation_StageDataGridView.AutoGenerateColumns = false;
            this.creation_StageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creation_StageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.creation_StageDataGridView.DataSource = this.creation_StageBindingSource;
            this.creation_StageDataGridView.Location = new System.Drawing.Point(12, 121);
            this.creation_StageDataGridView.Name = "creation_StageDataGridView";
            this.creation_StageDataGridView.Size = new System.Drawing.Size(677, 151);
            this.creation_StageDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Stage_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание этапа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 620;
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
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(536, 29);
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
            this.logOutButton.Location = new System.Drawing.Point(578, 413);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 23);
            this.logOutButton.TabIndex = 55;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // CreationStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.addStageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.creation_StageDataGridView);
            this.Controls.Add(this.creation_StageBindingNavigator);
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
            ((System.ComponentModel.ISupportInitialize)(this.creation_StageBindingNavigator)).EndInit();
            this.creation_StageBindingNavigator.ResumeLayout(false);
            this.creation_StageBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator creation_StageBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton creation_StageBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView creation_StageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand addStageCommand;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label label1;
        private RoundButton addStageButton;
        private System.Windows.Forms.Button logOutButton;
    }
}