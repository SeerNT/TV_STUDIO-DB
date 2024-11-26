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
    public partial class NewUserForm : Form
    {
        private UserManagementForm manageForm;

        public NewUserForm(UserManagementForm manageForm)
        {
            InitializeComponent();
            this.manageForm = manageForm;
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text != "")
            {
                if (passwordTextBox.Text == passwordConfirmTextBox.Text)
                {
                    if (userRoleComboBox.Text != "")
                    {
                        newUserCommand.Parameters["@login"].Value = loginTextBox.Text;

                        newUserCommand.Parameters["@password"].Value = passwordConfirmTextBox.Text;

                        switch (userRoleComboBox.SelectedItem)
                        {
                            case "Менеджер":
                                newUserCommand.Parameters["@role"].Value = "manager";
                                break;
                            case "Член съёмочной команды":
                                newUserCommand.Parameters["@role"].Value = "crew";
                                break;
                            case "Режиссер":
                                newUserCommand.Parameters["@role"].Value = "director";
                                break;
                            case "Продюсер":
                                newUserCommand.Parameters["@role"].Value = "producer";
                                break;
                            case "Монтажер":
                                newUserCommand.Parameters["@role"].Value = "edit";
                                break;
                        }

                        // открыть соединение с БД
                        sqlConnection1.Open();

                        newUserCommand.ExecuteNonQuery();
                        // закрыть соединение с БД
                        sqlConnection1.Close();

                        string result = (string)newUserCommand.Parameters["@res"].Value;

                        if (result == "GOOD")
                        {
                            MessageBox.Show("Новый пользователь был добавлен",
                            "Успешно", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                            manageForm.UpdateTable();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Пользователь с таким логином уже существует",
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
                            "Роль не была выбрана",
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
                            "Пароли не совпадают",
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
                            "Поле Логин должно быть заполнено",
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
