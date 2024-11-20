using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Телестудии
{
    public partial class CreationStageForm : Form
    {
        private short lastStageID;
        public CreationStageForm()
        {
            InitializeComponent();
        }

        private void creation_StageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.creation_StageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }

        private void CreationStageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Creation_Stage". При необходимости она может быть перемещена или удалена.
            this.creation_StageTableAdapter.Fill(this.бД_ТелестудииDataSet.Creation_Stage);

            int lastRowNum = бД_ТелестудииDataSet.Creation_Stage.Rows.Count - 1;
            lastStageID = (short)бД_ТелестудииDataSet.Creation_Stage.Rows[lastRowNum].ItemArray[0];
        }

        private void CreationStageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void videoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)videoComboBox.SelectedItem;

            if(row != null)
                creation_StageBindingSource.Filter = "ID_Videomaterial='" + row.Row[0].ToString() + "'";
        }

        private void addStageButton_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)videoComboBox.SelectedItem;

            if(descTextBox.Text != "")
            {
                lastStageID++;

                addStageCommand.Parameters["@stage_id"].Value = lastStageID;
                addStageCommand.Parameters["@video_id"].Value = row.Row[0];
                addStageCommand.Parameters["@desc"].Value = descTextBox.Text;

                sqlConnection1.Open();
                addStageCommand.ExecuteNonQuery();
                sqlConnection1.Close();

                MessageBox.Show("Этап был добавлен",
                    "Успешно", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            else
            {
                MessageBox.Show(
                        "Описание этапа не может быть пустым",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
            }
        }
    }
}
