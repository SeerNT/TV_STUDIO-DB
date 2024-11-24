using System;
using System.Collections;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void OpenMainForm(string role)
        {
            if (role == "crew")
            {
                Program.filmCrewForm = new FilmCrewForm();
                Program.filmCrewForm.Show();

                Program.openForms.Add(Program.filmCrewForm);
            }
            else if(role == "manager")
            {
                Program.managerMainForm = new ManagerMainForm();
                Program.managerMainForm.Show();

                Program.openForms.Add(Program.managerMainForm);
            }
            else if (role == "edit")
            {
                Program.broadcastsForm = new BroadcastPlaybackPlanForm();
                Program.broadcastsForm.Show();

                Program.openForms.Add(Program.broadcastsForm);
            }
            else if (role == "producer")
            {
                Program.creationStageForm = new CreationStageForm();
                Program.creationStageForm.Show();
                
                Program.openForms.Add(Program.creationStageForm);
            }
            else if (role == "director")
            {
                Program.director_broadcastsForm = new Director_BroadcastPlaybackPlanForm();
                Program.director_broadcastsForm.Show();

                Program.openForms.Add(Program.director_broadcastsForm);
            }

            this.Close();
        }

        private void Auth()
        {
            SqlConnection sqlConnection = new SqlConnection(Program.conString);
            sqlConnection.Open();

            SqlCommand checkUserLogin = new SqlCommand("SELECT COUNT(*) FROM Auth WHERE (userLogin = @user)", sqlConnection);
            checkUserLogin.Parameters.AddWithValue("@user", loginTextBox.Text);

            int UserExist = (int)checkUserLogin.ExecuteScalar();

            if (UserExist > 0)
            {
                SqlCommand checkUserLoginPassword = new SqlCommand("SELECT COUNT(*) FROM Auth WHERE (userLogin = @user) and (userPassword = @pass)", sqlConnection);
                checkUserLoginPassword.Parameters.AddWithValue("@user", loginTextBox.Text);
                checkUserLoginPassword.Parameters.AddWithValue("@pass", passwordTextBox.Text);

                int UserCorrectAuth = (int)checkUserLoginPassword.ExecuteScalar();

                if (UserCorrectAuth > 0)
                {
                    SqlCommand getUserRole = new SqlCommand("SELECT userPosition FROM Auth WHERE (userLogin = @user) and (userPassword = @pass)", sqlConnection);
                    getUserRole.Parameters.AddWithValue("@user", loginTextBox.Text);
                    getUserRole.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                    string userRole = (string)getUserRole.ExecuteScalar();
                    OpenMainForm(userRole);
                }
                else
                {
                    MessageBox.Show(
                        "Неправильный пароль",
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
                    "Пользователь с данным логином не найден",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
            }
            sqlConnection.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.openForms.All(f => f == null)){
                Application.Exit();
            }    
        }

        private void loginTextBox_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Auth();
            }
        }
    }
}
