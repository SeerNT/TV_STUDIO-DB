using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Телестудии
{
    public partial class VideomaterialsForm : Form
    {
        private EditorProgressForm editorProgressForm;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);

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
    }
}
