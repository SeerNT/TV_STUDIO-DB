using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace БД_Телестудии
{
    public partial class Manager_BroadcastPlaybackPlanForm : Form
    {
        private bool isDetailed = false;

        public Manager_BroadcastPlaybackPlanForm()
        {
            InitializeComponent();
        }

        private void ShowBroadcastsPlan()
        {
            isDetailed = false;

            broadcastsPlaybackPlanDataGridView.Visible = true;
            broadcastsPlaybackPlan_DetailedDataGridView.Visible = false;

            fieldListBox.Visible = true;

            sortButton.Enabled = false;

            detailedFieldListBox.Visible = false;
        }

        private void ShowBroadcastsPlan_Detailed()
        {
            isDetailed = true;

            broadcastsPlaybackPlanDataGridView.Visible = false;
            broadcastsPlaybackPlan_DetailedDataGridView.Visible = true;

            fieldListBox.Visible = false;

            sortButton.Enabled = false;

            detailedFieldListBox.Visible = true;
        }

        private void detailedTableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (detailedTableCheckBox.Checked)
            {
                ShowBroadcastsPlan_Detailed();
            }
            else
            {
                ShowBroadcastsPlan();
            }
        }

        private void Manager_BroadcastPlaybackPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlan_DetailedTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlan_DetailedTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if(!isDetailed)
                broadcastsPlaybackPlanBindingSource.Filter = "";
            else
                broadcastsPlaybackPlan_DetailedBindingSource.Filter = "";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!isDetailed)
            {
                DataGridViewColumn col = default(DataGridViewColumn);
                switch (fieldListBox.SelectedIndex)
                {
                    case 0:
                        col = dataGridViewTextBoxColumn1;
                        break;
                    case 1:
                        col = dataGridViewTextBoxColumn2;
                        break;
                    case 2:
                        col = dataGridViewTextBoxColumn3;
                        break;
                    case 3:
                        col = dataGridViewTextBoxColumn4;
                        break;
                }

                if (ascButton.Checked)
                {
                    broadcastsPlaybackPlanDataGridView.Sort(col, ListSortDirection.Ascending);
                }
                else
                {
                    broadcastsPlaybackPlanDataGridView.Sort(col, ListSortDirection.Descending);
                }
            }
            else
            {
                DataGridViewColumn col = default(DataGridViewColumn);
                switch (detailedFieldListBox.SelectedIndex)
                {
                    case 0:
                        col = dataGridViewTextBoxColumn5;
                        break;
                    case 1:
                        col = dataGridViewTextBoxColumn6;
                        break;
                    case 2:
                        col = dataGridViewTextBoxColumn7;
                        break;
                    case 3:
                        col = dataGridViewTextBoxColumn8;
                        break;
                    case 4:
                        col = dataGridViewTextBoxColumn9;
                        break;
                    case 5:
                        col = dataGridViewTextBoxColumn11;
                        break;
                }

                if (ascButton.Checked)
                {
                    broadcastsPlaybackPlan_DetailedDataGridView.Sort(col, ListSortDirection.Ascending);
                }
                else
                {
                    broadcastsPlaybackPlan_DetailedDataGridView.Sort(col, ListSortDirection.Descending);
                }
            }
        }

        private void detailedFieldListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;
        }

        private void fieldListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;
        }

        private void findByDescriptionButton_Click(object sender, EventArgs e)
        {
            if (ideaDescriptionTextBox.Text != "")
            {
                if (!isDetailed)
                    broadcastsPlaybackPlanBindingSource.Filter = "Трансляция like '" +
                    ideaDescriptionTextBox.Text + "%'";
                else
                    broadcastsPlaybackPlan_DetailedBindingSource.Filter = "Трансляция like '" +
                    ideaDescriptionTextBox.Text + "%'";
            }
            else
            {
                MessageBox.Show(
                        "Поле Трансляция не может быть пустым",
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
