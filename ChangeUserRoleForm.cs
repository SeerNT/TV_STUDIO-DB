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
    public partial class ChangeUserRoleForm : Form
    {
        public ChangeUserRoleForm()
        {
            InitializeComponent();
        }

        private void changeUserRoleButton_Click(object sender, EventArgs e)
        {
            if(userRoleComboBox.Text != "")
            {
                changeUserRoleCommand.Parameters["@login"].Value = loginTextBox.Text;
                changeUserRoleCommand.Parameters["@newRole"].Value = "manager";
                switch (userRoleComboBox.SelectedItem)
                {
                    case "Менеджер":
                        changeUserRoleCommand.Parameters["@newRole"].Value = "manager";
                        break;
                    case "Член съёмочной команды":
                        changeUserRoleCommand.Parameters["@newRole"].Value = "crew";
                        break;
                    case "Режиссер":
                        changeUserRoleCommand.Parameters["@newRole"].Value = "director";
                        break;
                    case "Продюсер":
                        changeUserRoleCommand.Parameters["@newRole"].Value = "producer";
                        break;
                    case "Монтажер":
                        changeUserRoleCommand.Parameters["@newRole"].Value = "edit";
                        break;
                }

                // открыть соединение с БД
                sqlConnection1.Open();

                changeUserRoleCommand.ExecuteNonQuery();
                // закрыть соединение с БД
                sqlConnection1.Close();

                string result = (string)changeUserRoleCommand.Parameters["@res"].Value;

                if(result == "GOOD")
                {
                    MessageBox.Show("Роль была сменена",
                    "Успешно", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Пользователь с таким логином не найден",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
                }
            }
            else
            {
                MessageBox.Show(
                        "Новая роль не была выбрана",
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
