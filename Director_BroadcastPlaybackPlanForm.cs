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
    public partial class Director_BroadcastPlaybackPlanForm : Form
    {
        public static string currentVideomaterialName;

        private DirectorEditingForm directorEditingForm;

        public Director_BroadcastPlaybackPlanForm()
        {
            InitializeComponent();
        }

        private void ShowBroadcastsPlan()
        {
            broadcastsPlaybackPlanDataGridView.Visible = true;
            broadcastsPlaybackPlan_DetailedDataGridView.Visible = false;
        }

        private void ShowBroadcastsPlan_Detailed()
        {
            broadcastsPlaybackPlanDataGridView.Visible = false;
            broadcastsPlaybackPlan_DetailedDataGridView.Visible = true;
        }


        private void BroadcastPlaybackPlanForm_Load(object sender, EventArgs e)
        {
            this.broadcastsPlaybackPlan_DetailedTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);

            ShowBroadcastsPlan();
        }

        private void BroadcastPlaybackPlanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void editBroadcastButton_Click(object sender, EventArgs e)
        {
            if (directorEditingForm != null)
                directorEditingForm.Close();

            directorEditingForm = new DirectorEditingForm();
            directorEditingForm.Show();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            currentVideomaterialName = comboBox1.Text;
        }


        private void detailedTableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(detailedTableCheckBox.Checked)
            {
                ShowBroadcastsPlan_Detailed();
            }
            else
            {
                ShowBroadcastsPlan();
            }
        }
    }
}
