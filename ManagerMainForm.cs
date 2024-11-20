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
    public partial class ManagerMainForm : Form
    {
        private VideomaterialsForm videosForm;
        private UserManagementForm userManagementForm;
        private Manager_BroadcastPlaybackPlanForm broadcastPlaybackPlanForm;

        public ManagerMainForm()
        {
            InitializeComponent();
        }

        private void ManagerMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openVideosFormButton_Click(object sender, EventArgs e)
        {
            if(videosForm != null)
                videosForm.Close();

            videosForm = new VideomaterialsForm();
            videosForm.Show();
        }

        private void openAuthEditFormButton_Click(object sender, EventArgs e)
        {
            if (userManagementForm != null)
                userManagementForm.Close();

            userManagementForm = new UserManagementForm();
            userManagementForm.Show();
        }

        private void openBroadcastsFormButton_Click(object sender, EventArgs e)
        {
            if (broadcastPlaybackPlanForm != null)
                broadcastPlaybackPlanForm.Close();

            broadcastPlaybackPlanForm = new Manager_BroadcastPlaybackPlanForm();
            broadcastPlaybackPlanForm.Show();
        }
    }
}
