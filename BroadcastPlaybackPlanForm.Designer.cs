﻿namespace БД_Телестудии
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
            this.detailedTableCheckBox = new System.Windows.Forms.CheckBox();
            this.broadcastsPlaybackPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.broadcastsPlaybackPlan_DetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openProgressButton = new БД_Телестудии.RoundButton();
            this.propOpenButton = new БД_Телестудии.RoundButton();
            this.broadcastsPlaybackPlanTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter();
            this.broadcastsPlaybackPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.broadcastsPlaybackPlan_DetailedTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlan_DetailedTableAdapter();
            this.broadcastsPlaybackPlan_DetailedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДТелестудииDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videomaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedDataGridView)).BeginInit();
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
            // detailedTableCheckBox
            // 
            this.detailedTableCheckBox.AutoSize = true;
            this.detailedTableCheckBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedTableCheckBox.Location = new System.Drawing.Point(576, 30);
            this.detailedTableCheckBox.Name = "detailedTableCheckBox";
            this.detailedTableCheckBox.Size = new System.Drawing.Size(194, 22);
            this.detailedTableCheckBox.TabIndex = 13;
            this.detailedTableCheckBox.Text = "Подробное отображение";
            this.detailedTableCheckBox.UseVisualStyleBackColor = true;
            this.detailedTableCheckBox.CheckedChanged += new System.EventHandler(this.detailedTableCheckBox_CheckedChanged);
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
            // broadcastsPlaybackPlan_DetailedBindingSource
            // 
            this.broadcastsPlaybackPlan_DetailedBindingSource.DataMember = "BroadcastsPlaybackPlan_Detailed";
            this.broadcastsPlaybackPlan_DetailedBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // openProgressButton
            // 
            this.openProgressButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.openProgressButton.BorderColor = System.Drawing.Color.White;
            this.openProgressButton.BorderWidth = 2F;
            this.openProgressButton.ButtonText = "Прогресс монтажа";
            this.openProgressButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProgressButton.ForeColor = System.Drawing.Color.White;
            this.openProgressButton.Location = new System.Drawing.Point(298, 316);
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
            this.propOpenButton.Location = new System.Drawing.Point(27, 316);
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
            this.broadcastsPlaybackPlanDataGridView.Size = new System.Drawing.Size(743, 217);
            this.broadcastsPlaybackPlanDataGridView.TabIndex = 15;
            this.broadcastsPlaybackPlanDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.broadcastsPlaybackPlanDataGridView_CellMouseDoubleClick);
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
            this.broadcastsPlaybackPlan_DetailedDataGridView.Location = new System.Drawing.Point(27, 71);
            this.broadcastsPlaybackPlan_DetailedDataGridView.Name = "broadcastsPlaybackPlan_DetailedDataGridView";
            this.broadcastsPlaybackPlan_DetailedDataGridView.ReadOnly = true;
            this.broadcastsPlaybackPlan_DetailedDataGridView.Size = new System.Drawing.Size(743, 217);
            this.broadcastsPlaybackPlan_DetailedDataGridView.TabIndex = 15;
            this.broadcastsPlaybackPlan_DetailedDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.broadcastsPlaybackPlan_DetailedDataGridView_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
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
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата воспроизведения";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Длительность";
            this.dataGridViewTextBoxColumn9.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Частота кадров";
            this.dataGridViewTextBoxColumn10.HeaderText = "Частота кадров";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn11.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
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
            // BroadcastPlaybackPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 412);
            this.Controls.Add(this.broadcastsPlaybackPlan_DetailedDataGridView);
            this.Controls.Add(this.broadcastsPlaybackPlanDataGridView);
            this.Controls.Add(this.propOpenButton);
            this.Controls.Add(this.openProgressButton);
            this.Controls.Add(this.detailedTableCheckBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broadcastsPlaybackPlan_DetailedDataGridView)).EndInit();
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
        private System.Windows.Forms.CheckBox detailedTableCheckBox;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlanBindingSource;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource broadcastsPlaybackPlan_DetailedBindingSource;
        private RoundButton openProgressButton;
        private RoundButton propOpenButton;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlanTableAdapter broadcastsPlaybackPlanTableAdapter;
        private System.Windows.Forms.DataGridView broadcastsPlaybackPlanDataGridView;
        private БД_ТелестудииDataSetTableAdapters.BroadcastsPlaybackPlan_DetailedTableAdapter broadcastsPlaybackPlan_DetailedTableAdapter;
        private System.Windows.Forms.DataGridView broadcastsPlaybackPlan_DetailedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}