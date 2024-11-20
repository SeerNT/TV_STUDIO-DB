namespace БД_Телестудии
{
    partial class EditorProgressForm
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
            this.unusedVideomaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unusedVideomaterialsTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.UnusedVideomaterialsTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.unusedVideomaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.usedVideomaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usedVideomaterialsTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.UsedVideomaterialsTableAdapter();
            this.usedVideomaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unusedVideomaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unusedVideomaterialsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedVideomaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedVideomaterialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unusedVideomaterialsBindingSource
            // 
            this.unusedVideomaterialsBindingSource.DataMember = "UnusedVideomaterials";
            this.unusedVideomaterialsBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // unusedVideomaterialsTableAdapter
            // 
            this.unusedVideomaterialsTableAdapter.ClearBeforeFill = true;
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
            // unusedVideomaterialsDataGridView
            // 
            this.unusedVideomaterialsDataGridView.AutoGenerateColumns = false;
            this.unusedVideomaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unusedVideomaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.unusedVideomaterialsDataGridView.DataSource = this.unusedVideomaterialsBindingSource;
            this.unusedVideomaterialsDataGridView.Location = new System.Drawing.Point(12, 34);
            this.unusedVideomaterialsDataGridView.Name = "unusedVideomaterialsDataGridView";
            this.unusedVideomaterialsDataGridView.ReadOnly = true;
            this.unusedVideomaterialsDataGridView.Size = new System.Drawing.Size(504, 220);
            this.unusedVideomaterialsDataGridView.TabIndex = 1;
            // 
            // usedVideomaterialsBindingSource
            // 
            this.usedVideomaterialsBindingSource.DataMember = "UsedVideomaterials";
            this.usedVideomaterialsBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // usedVideomaterialsTableAdapter
            // 
            this.usedVideomaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // usedVideomaterialsDataGridView
            // 
            this.usedVideomaterialsDataGridView.AutoGenerateColumns = false;
            this.usedVideomaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usedVideomaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usedVideomaterialsDataGridView.DataSource = this.usedVideomaterialsBindingSource;
            this.usedVideomaterialsDataGridView.Location = new System.Drawing.Point(12, 303);
            this.usedVideomaterialsDataGridView.Name = "usedVideomaterialsDataGridView";
            this.usedVideomaterialsDataGridView.ReadOnly = true;
            this.usedVideomaterialsDataGridView.Size = new System.Drawing.Size(504, 220);
            this.usedVideomaterialsDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Неиспользованные видеоматериалы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Использованные видеоматериалы";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата загрузки";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата загрузки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата загрузки";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата загрузки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // EditorProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usedVideomaterialsDataGridView);
            this.Controls.Add(this.unusedVideomaterialsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorProgressForm";
            this.Text = "Прогресс монтажа";
            this.Load += new System.EventHandler(this.EditorProgressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unusedVideomaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unusedVideomaterialsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedVideomaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedVideomaterialsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource unusedVideomaterialsBindingSource;
        private БД_ТелестудииDataSetTableAdapters.UnusedVideomaterialsTableAdapter unusedVideomaterialsTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView unusedVideomaterialsDataGridView;
        private System.Windows.Forms.BindingSource usedVideomaterialsBindingSource;
        private БД_ТелестудииDataSetTableAdapters.UsedVideomaterialsTableAdapter usedVideomaterialsTableAdapter;
        private System.Windows.Forms.DataGridView usedVideomaterialsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}