namespace БД_Телестудии
{
    partial class VideomaterialProperty
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editPropButton = new БД_Телестудии.RoundButton();
            this.бД_ТелестудииDataSet = new БД_Телестудии.БД_ТелестудииDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.videomaterialComboBox = new System.Windows.Forms.ComboBox();
            this.videoPropsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.ChangeVideomaterialPropsCommand = new System.Data.SqlClient.SqlCommand();
            this.videoPropsTableAdapter = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.VideoPropsTableAdapter();
            this.tableAdapterManager = new БД_Телестудии.БД_ТелестудииDataSetTableAdapters.TableAdapterManager();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.framerateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPropsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Автор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Кадровая частота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Характеристики видеоматериала";
            // 
            // editPropButton
            // 
            this.editPropButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.editPropButton.BorderColor = System.Drawing.Color.White;
            this.editPropButton.BorderWidth = 2F;
            this.editPropButton.ButtonText = "Изменить";
            this.editPropButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPropButton.ForeColor = System.Drawing.Color.White;
            this.editPropButton.Location = new System.Drawing.Point(547, 142);
            this.editPropButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.editPropButton.MouseOverBorderColor = System.Drawing.Color.Cyan;
            this.editPropButton.Name = "editPropButton";
            this.editPropButton.OnClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.editPropButton.Radius = 10;
            this.editPropButton.Size = new System.Drawing.Size(187, 62);
            this.editPropButton.TabIndex = 52;
            this.editPropButton.UseMouseOverBackColor = true;
            this.editPropButton.Click += new System.EventHandler(this.editPropButton_Click);
            // 
            // бД_ТелестудииDataSet
            // 
            this.бД_ТелестудииDataSet.DataSetName = "БД_ТелестудииDataSet";
            this.бД_ТелестудииDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Видеоматериал";
            // 
            // videomaterialComboBox
            // 
            this.videomaterialComboBox.DataSource = this.videoPropsBindingSource;
            this.videomaterialComboBox.DisplayMember = "Idea_description";
            this.videomaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videomaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videomaterialComboBox.FormattingEnabled = true;
            this.videomaterialComboBox.Location = new System.Drawing.Point(205, 73);
            this.videomaterialComboBox.Name = "videomaterialComboBox";
            this.videomaterialComboBox.Size = new System.Drawing.Size(529, 24);
            this.videomaterialComboBox.TabIndex = 55;
            this.videomaterialComboBox.ValueMember = "Idea_description";
            // 
            // videoPropsBindingSource
            // 
            this.videoPropsBindingSource.DataMember = "VideoProps";
            this.videoPropsBindingSource.DataSource = this.бД_ТелестудииDataSet;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-K054NBE;Initial Catalog=\"БД Телестудии\";Integrated Security=T" +
    "rue;Pooling=False;Encrypt=True;TrustServerCertificate=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // ChangeVideomaterialPropsCommand
            // 
            this.ChangeVideomaterialPropsCommand.CommandText = "ChangeVideomaterialProps";
            this.ChangeVideomaterialPropsCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.ChangeVideomaterialPropsCommand.Connection = this.sqlConnection1;
            this.ChangeVideomaterialPropsCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@videoTitle", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newFramerate", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@newAuthor", System.Data.SqlDbType.VarChar)});
            // 
            // videoPropsTableAdapter
            // 
            this.videoPropsTableAdapter.ClearBeforeFill = true;
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
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoPropsBindingSource, "Author", true));
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(205, 170);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(213, 26);
            this.authorTextBox.TabIndex = 59;
            this.authorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authorTextBox_KeyPress);
            // 
            // framerateNumericUpDown
            // 
            this.framerateNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.videoPropsBindingSource, "Framerate", true));
            this.framerateNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framerateNumericUpDown.Location = new System.Drawing.Point(16, 170);
            this.framerateNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.framerateNumericUpDown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.framerateNumericUpDown.Name = "framerateNumericUpDown";
            this.framerateNumericUpDown.Size = new System.Drawing.Size(127, 26);
            this.framerateNumericUpDown.TabIndex = 60;
            this.framerateNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // VideomaterialProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 224);
            this.Controls.Add(this.framerateNumericUpDown);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videomaterialComboBox);
            this.Controls.Add(this.editPropButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideomaterialProperty";
            this.Text = "Изменение характеристик";
            this.Load += new System.EventHandler(this.VideomaterialProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_ТелестудииDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPropsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.framerateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RoundButton editPropButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox videomaterialComboBox;
        private БД_ТелестудииDataSet бД_ТелестудииDataSet;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand ChangeVideomaterialPropsCommand;
        private System.Windows.Forms.BindingSource videoPropsBindingSource;
        private БД_ТелестудииDataSetTableAdapters.VideoPropsTableAdapter videoPropsTableAdapter;
        private БД_ТелестудииDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.NumericUpDown framerateNumericUpDown;
    }
}