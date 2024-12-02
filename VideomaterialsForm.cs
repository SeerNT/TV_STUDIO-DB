using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Телестудии
{
    public partial class VideomaterialsForm : Form
    {
        private EditorProgressForm editorProgressForm;

        private int id;

        public VideomaterialsForm()
        {
            InitializeComponent();
        }

        private void videomaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videomaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);
        }

        private void VideomaterialsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Creation_Stage". При необходимости она может быть перемещена или удалена.
            this.creation_StageTableAdapter.Fill(this.бД_ТелестудииDataSet.Creation_Stage);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
            id = int.Parse(iD_VideomaterialLabel1.Text);
            creation_StageBindingSource.Filter = "ID_Videomaterial ='"
        + id + "'";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = default(DataGridViewColumn);
            switch (fieldTextBox.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
            }

            if(ascButton.Checked)
            {
                videomaterialDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                videomaterialDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void fieldTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;
        }

        private void findByDescriptionButton_Click(object sender, EventArgs e)
        {
            if(ideaDescriptionTextBox.Text != "")
                videomaterialBindingSource.Filter = "Idea_description like '" + 
                    ideaDescriptionTextBox.Text + "%'";
            else
            {
                MessageBox.Show(
                        "Поле Описание не может быть пустым",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            videomaterialBindingSource.Filter = "";
        }

        private void openProgressButton_Click(object sender, EventArgs e)
        {
            if (editorProgressForm != null)
                editorProgressForm.Close();

            editorProgressForm = new EditorProgressForm();
            editorProgressForm.Show();
        }

        private void videomaterialDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (videomaterialDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(iD_VideomaterialLabel1.Text);
                    creation_StageBindingSource.Filter = "ID_Videomaterial ='"
                + id + "'";
                }
            }
        }

        private void videomaterialDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (videomaterialDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(iD_VideomaterialLabel1.Text);
                    creation_StageBindingSource.Filter = "ID_Videomaterial ='"
                + id + "'";
                }
            }
        }

        private void videomaterialDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (videomaterialDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(iD_VideomaterialLabel1.Text);
                    creation_StageBindingSource.Filter = "ID_Videomaterial ='"
                + id + "'";
                }
            }
        }

        private void videomaterialDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (videomaterialDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    id = int.Parse(iD_VideomaterialLabel1.Text);
                    creation_StageBindingSource.Filter = "ID_Videomaterial ='"
                + id + "'";
                }
            }
        }
    }
}
