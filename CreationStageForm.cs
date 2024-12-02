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

        private bool isLogOut = false;

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

        public void UpdateTable()
        {
            this.creation_StageTableAdapter.Fill(this.бД_ТелестудииDataSet.Creation_Stage);
        }

        private void CreationStageForm_Load(object sender, EventArgs e)
        {
            isLogOut = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Creation_Stage". При необходимости она может быть перемещена или удалена.
            this.creation_StageTableAdapter.Fill(this.бД_ТелестудииDataSet.Creation_Stage);

            int lastRowNum = бД_ТелестудииDataSet.Creation_Stage.Rows.Count - 1;
            lastStageID = (short)бД_ТелестудииDataSet.Creation_Stage.Rows[lastRowNum].ItemArray[0];
        }

        private void CreationStageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogOut)
            {
                Application.Exit();
            }
            else
            {
                if (Program.openForms.All(f => f == null))
                {
                    Application.Exit();
                }
            }
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

                UpdateTable();
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Program.authForm = new Authorization();
            Program.authForm.Show();

            isLogOut = true;

            this.Close();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            creation_StageBindingSource.RemoveCurrent();

            this.Validate();
            this.creation_StageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

            MessageBox.Show("Этап был удалён!",
                    "Успешно", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
        }
    }
}
