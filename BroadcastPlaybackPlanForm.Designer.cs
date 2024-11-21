namespace БД_Телестудии
{
    partial class BroadcastPlaybackPlanForm
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
            this.videomaterialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.бДТелестудииDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.videomaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videomaterialTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter();
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.openProgressButton = new БД_Телестудии.RoundButton();
            this.propOpenButton = new БД_Телестудии.RoundButton();
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.broadcastsPlaybackPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.video_EditingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.video_EditingTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.Video_EditingTableAdapter();
            this.durationLabel1 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.framerateLabel1 = new System.Windows.Forms.Label();
            this.authorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДТелестудииDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_EditingBindingSource)).BeginInit();
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
            // videomaterialBindingSource1
            // 
            this.videomaterialBindingSource1.DataMember = "Videomaterial";
            this.videomaterialBindingSource1.DataSource = this.бДТелестудииDataSetBindingSource;
            // 
            // бДТелестудииDataSetBindingSource
            // 
            this.бДТелестудииDataSetBindingSource.DataSource = this.бД_ТелестудииDataSet;
            this.бДТелестудииDataSetBindingSource.Position = 0;
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
            // broadcastsPlaybackPlanBindingSource
            // 
            this.broadcastsPlaybackPlanBindingSource.DataMember = "BroadcastsPlaybackPlan";
            this.broadcastsPlaybackPlanBindingSource.DataSource = this.бД_ТелестудииDataSet;
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
            // openProgressButton
            // 
            this.openProgressButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openProgressButton.BorderColor = System.Drawing.Color.White;
            this.openProgressButton.BorderWidth = 2F;
            this.openProgressButton.ButtonText = "Прогресс монтажа";
            this.openProgressButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProgressButton.ForeColor = System.Drawing.Color.White;
            this.openProgressButton.Location = new System.Drawing.Point(298, 350);
            this.openProgressButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.openProgressButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.openProgressButton.Name = "openProgressButton";
            this.openProgressButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.openProgressButton.Radius = 10;
            this.openProgressButton.Size = new System.Drawing.Size(238, 72);
            this.openProgressButton.TabIndex = 14;
            this.openProgressButton.UseMouseOverBackColor = true;
            this.openProgressButton.Click += new System.EventHandler(this.openProgressButton_Click);
            // 
            // propOpenButton
            // 
            this.propOpenButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.propOpenButton.BorderColor = System.Drawing.Color.White;
            this.propOpenButton.BorderWidth = 2F;
            this.propOpenButton.ButtonText = "Характеристики видеоматериала";
            this.propOpenButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propOpenButton.ForeColor = System.Drawing.Color.White;
            this.propOpenButton.Location = new System.Drawing.Point(27, 350);
            this.propOpenButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.propOpenButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.propOpenButton.Name = "propOpenButton";
            this.propOpenButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.propOpenButton.Radius = 10;
            this.propOpenButton.Size = new System.Drawing.Size(262, 84);
            this.propOpenButton.TabIndex = 15;
            this.propOpenButton.UseMouseOverBackColor = true;
            this.propOpenButton.Click += new System.EventHandler(this.propOpenButton_Click);
            // 
            // broadcastsPlaybackPlanTableAdapter
            // 
            this.broadcastsPlaybackPlanTableAdapter.ClearBeforeFill = true;
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
            this.broadcastsPlaybackPlanDataGridView.Location = new System.Drawing.Point(27, 71);
            this.broadcastsPlaybackPlanDataGridView.Name = "broadcastsPlaybackPlanDataGridView";
            this.broadcastsPlaybackPlanDataGridView.ReadOnly = true;
            this.broadcastsPlaybackPlanDataGridView.Size = new System.Drawing.Size(509, 272);
            this.broadcastsPlaybackPlanDataGridView.TabIndex = 15;
            this.broadcastsPlaybackPlanDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.broadcastsPlaybackPlanDataGridView_CellMouseClick);
            this.broadcastsPlaybackPlanDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.broadcastsPlaybackPlanDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn2.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Внешний канал";
            this.dataGridViewTextBoxColumn3.HeaderText = "Внешний канал";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Длительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Частота кадров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Автор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.broadcastsPlaybackPlanBindingSource, "ID", true));
            this.iDLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel1.Location = new System.Drawing.Point(555, 110);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 21;
            this.iDLabel1.Text = "label6";
            // 
            // video_EditingBindingSource
            // 
            this.video_EditingBindingSource.DataMember = "Video_Editing";
            this.video_EditingBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // video_EditingTableAdapter
            // 
            this.video_EditingTableAdapter.ClearBeforeFill = true;
            // 
            // durationLabel1
            // 
            this.durationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.video_EditingBindingSource, "Duration", true));
            this.durationLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel1.Location = new System.Drawing.Point(555, 170);
            this.durationLabel1.Name = "durationLabel1";
            this.durationLabel1.Size = new System.Drawing.Size(100, 23);
            this.durationLabel1.TabIndex = 22;
            this.durationLabel1.Text = "label6";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // framerateLabel1
            // 
            this.framerateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.video_EditingBindingSource, "Framerate", true));
            this.framerateLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framerateLabel1.Location = new System.Drawing.Point(555, 230);
            this.framerateLabel1.Name = "framerateLabel1";
            this.framerateLabel1.Size = new System.Drawing.Size(100, 23);
            this.framerateLabel1.TabIndex = 23;
            this.framerateLabel1.Text = "label6";
            // 
            // authorLabel1
            // 
            this.authorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.video_EditingBindingSource, "Author", true));
            this.authorLabel1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel1.Location = new System.Drawing.Point(555, 292);
            this.authorLabel1.Name = "authorLabel1";
            this.authorLabel1.Size = new System.Drawing.Size(100, 23);
            this.authorLabel1.TabIndex = 24;
            this.authorLabel1.Text = "label6";
            // 
            // BroadcastPlaybackPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 454);
            this.Controls.Add(this.authorLabel1);
            this.Controls.Add(this.framerateLabel1);
            this.Controls.Add(this.durationLabel1);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.broadcastsPlaybackPlanDataGridView);
            this.Controls.Add(this.propOpenButton);
            this.Controls.Add(this.openProgressButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BroadcastPlaybackPlanForm";
            this.Text = "Трансляции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BroadcastPlaybackPlanForm_FormClosed);
            this.Load += new System.EventHandler(this.BroadcastPlaybackPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДТелестудииDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_EditingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Windows.Forms.BindingSource videomaterialBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideomaterialTableAdapter videomaterialTableAdapter;
        private System.Windows.Forms.BindingSource videomaterialBindingSource1;
        private System.Windows.Forms.BindingSource бДТелестудииDataSetBindingSource;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RoundButton openProgressButton;
        private RoundButton propOpenButton;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private System.Windows.Forms.DataGridView broadcastsPlaybackPlanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.BindingSource video_EditingBindingSource;
        private БД_ТелестудииDataSetTableAdapters.Video_EditingTableAdapter video_EditingTableAdapter;
        private System.Windows.Forms.Label durationLabel1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label framerateLabel1;
        private System.Windows.Forms.Label authorLabel1;
    }
}