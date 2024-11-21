using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Телестудии
{
    public partial class VideomaterialProperty : Form
    {
        public VideomaterialProperty()
        {
            InitializeComponent();
        }

        private void editPropButton_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)videomaterialComboBox.SelectedItem;
            Console.WriteLine(row.Row[0].ToString());
            ChangeVideomaterialPropsCommand.Parameters["@videoTitle"].Value = row.Row[0].ToString();
            ChangeVideomaterialPropsCommand.Parameters["@newFramerate"].Value = 
                framerateNumericUpDown.Value;
            ChangeVideomaterialPropsCommand.Parameters["@newAuthor"].Value = authorTextBox.Text;

            sqlConnection1.Open();

            ChangeVideomaterialPropsCommand.ExecuteNonQuery();
            // закрыть соединение с БД
            sqlConnection1.Close();

            MessageBox.Show("Видеоматериал был изменен",
                "Успешно", MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.Close();
        }

        private void VideomaterialProperty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.VideoProps". При необходимости она может быть перемещена или удалена.
            this.videoPropsTableAdapter.Fill(this.бД_ТелестудииDataSet.VideoProps);
        }

        private void framerateUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (framerateNumericUpDown.Value > 360)
            {
                MessageBox.Show(
                    "Кадровая частота не может превышать 360 кадров/с",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            else if (framerateNumericUpDown.Value < 60)
            {
                MessageBox.Show(
                    "Кадровая частота не может быть меньше 60 кадров/с",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
        }

        private void authorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[.]").Success 
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
