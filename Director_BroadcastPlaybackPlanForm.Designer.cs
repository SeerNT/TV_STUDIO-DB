namespace БД_Телестудии
{
    partial class Director_BroadcastPlaybackPlanForm
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
            this.бДТелестудииDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.addBroadcastButton = new БД_Телестудии.RoundButton();
            this.director_BroadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.director_BroadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Director_BroadcastsPlaybackPlanTableAdapter();
            this.director_BroadcastsPlaybackPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДТелестудииDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_BroadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_BroadcastsPlaybackPlanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "План воспроизведения трансляций";
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бДТелестудииDataSetBindingSource
            // 
            this.бДТелестудииDataSetBindingSource.DataSource = this.бД_ТелестудииDataSet;
            this.бДТелестудииDataSetBindingSource.Position = 0;
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
            // broadcastsPlaybackPlanBindingSource
            // 
            this.broadcastsPlaybackPlanBindingSource.DataMember = "BroadcastsPlaybackPlan";
            this.broadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // broadcastsPlaybackPlanTableAdapter
            // 
            this.broadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // addBroadcastButton
            // 
            this.addBroadcastButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.addBroadcastButton.BorderColor = System.Drawing.Color.White;
            this.addBroadcastButton.BorderWidth = 2F;
            this.addBroadcastButton.ButtonText = "Добавить";
            this.addBroadcastButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBroadcastButton.ForeColor = System.Drawing.Color.White;
            this.addBroadcastButton.Location = new System.Drawing.Point(14, 387);
            this.addBroadcastButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addBroadcastButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.addBroadcastButton.Name = "addBroadcastButton";
            this.addBroadcastButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.addBroadcastButton.Radius = 10;
            this.addBroadcastButton.Size = new System.Drawing.Size(238, 72);
            this.addBroadcastButton.TabIndex = 52;
            this.addBroadcastButton.UseMouseOverBackColor = true;
            this.addBroadcastButton.Click += new System.EventHandler(this.addBroadcastButton_Click);
            // 
            // director_BroadcastsPlaybackPlanBindingSource
            // 
            this.director_BroadcastsPlaybackPlanBindingSource.DataMember = "Director_BroadcastsPlaybackPlan";
            this.director_BroadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // director_BroadcastsPlaybackPlanTableAdapter
            // 
            this.director_BroadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
            // 
            // director_BroadcastsPlaybackPlanDataGridView
            // 
            this.director_BroadcastsPlaybackPlanDataGridView.AutoGenerateColumns = false;
            this.director_BroadcastsPlaybackPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.director_BroadcastsPlaybackPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.director_BroadcastsPlaybackPlanDataGridView.DataSource = this.director_BroadcastsPlaybackPlanBindingSource;
            this.director_BroadcastsPlaybackPlanDataGridView.Location = new System.Drawing.Point(27, 70);
            this.director_BroadcastsPlaybackPlanDataGridView.Name = "director_BroadcastsPlaybackPlanDataGridView";
            this.director_BroadcastsPlaybackPlanDataGridView.ReadOnly = true;
            this.director_BroadcastsPlaybackPlanDataGridView.Size = new System.Drawing.Size(514, 310);
            this.director_BroadcastsPlaybackPlanDataGridView.TabIndex = 52;
            this.director_BroadcastsPlaybackPlanDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.director_BroadcastsPlaybackPlanDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn3.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Внешний канал";
            this.dataGridViewTextBoxColumn4.HeaderText = "Внешний канал";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(430, 444);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 23);
            this.logOutButton.TabIndex = 53;
            this.logOutButton.Text = "Выйти из аккаунта";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // Director_BroadcastPlaybackPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 479);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.director_BroadcastsPlaybackPlanDataGridView);
            this.Controls.Add(this.addBroadcastButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Director_BroadcastPlaybackPlanForm";
            this.Text = "Трансляции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BroadcastPlaybackPlanForm_FormClosed);
            this.Load += new System.EventHandler(this.BroadcastPlaybackPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДТелестудииDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_BroadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.director_BroadcastsPlaybackPlanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private System.Windows.Forms.BindingSource бДТелестудииDataSetBindingSource;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private RoundButton addBroadcastButton;
        private System.Windows.Forms.BindingSource director_BroadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.Director_BroadcastsPlaybackPlanTableAdapter director_BroadcastsPlaybackPlanTableAdapter;
        private System.Windows.Forms.DataGridView director_BroadcastsPlaybackPlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button logOutButton;
    }
}