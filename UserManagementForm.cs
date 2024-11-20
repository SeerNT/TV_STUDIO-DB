﻿using System;
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
    public partial class UserManagementForm : Form
    {
        private NewUserForm newUserForm;
        private ChangeUserPassForm changeUserPassForm;
        private ChangeUserRoleForm changeUserRoleForm;

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.бД_ТелестудииDataSet.Auth);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            if (newUserForm != null)
                newUserForm.Close();

            newUserForm = new NewUserForm();
            newUserForm.Show();
        }

        private void editUserPasswordButton_Click(object sender, EventArgs e)
        {
            if (changeUserPassForm != null)
                changeUserPassForm.Close();

            changeUserPassForm = new ChangeUserPassForm();
            changeUserPassForm.Show();
        }

        private void editUserRoleButton_Click(object sender, EventArgs e)
        {
            if (changeUserRoleForm != null)
                changeUserRoleForm.Close();

            changeUserRoleForm = new ChangeUserRoleForm();
            changeUserRoleForm.Show();
        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);
        }
    }
}
