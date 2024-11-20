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
    public partial class ChangeUserPassForm : Form
    {
        public ChangeUserPassForm()
        {
            InitializeComponent();
        }

        private void changeUserPassButton_Click(object sender, EventArgs e)
        {
            changeUserPassCommand.Parameters["@login"].Value = loginTextBox.Text;
            changeUserPassCommand.Parameters["@newPassword"].Value = passwordConfirmTextBox.Text;

            if (passwordTextBox.Text == passwordConfirmTextBox.Text)
            {
                // открыть соединение с БД
                sqlConnection1.Open();

                changeUserPassCommand.ExecuteNonQuery();
                // закрыть соединение с БД
                sqlConnection1.Close();

                string result = (string)changeUserPassCommand.Parameters["@res"].Value;

                if (result == "GOOD")
                {
                    MessageBox.Show("Пароль был сменён",
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
                        "Пароли не совпадают",
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
