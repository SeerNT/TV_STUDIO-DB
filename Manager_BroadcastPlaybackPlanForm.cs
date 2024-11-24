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
        public Manager_BroadcastPlaybackPlanForm()
        {
            InitializeComponent();
        }

        private void Manager_BroadcastPlaybackPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Manager_BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.manager_BroadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.Manager_BroadcastsPlaybackPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Broadcast". При необходимости она может быть перемещена или удалена.
            this.broadcastTableAdapter.Fill(this.бД_ТелестудииDataSet.Broadcast);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Manager_BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.manager_BroadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.Manager_BroadcastsPlaybackPlan);

            manager_BroadcastsPlaybackPlanBindingSource.Filter = "[Дата воспроизведения] < '" + DateTime.Today.ToString() + "'";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = default(DataGridViewColumn);
            switch (fieldListBox.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    col = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    col = dataGridViewTextBoxColumn6;
                    break;
            }

            if (ascButton.Checked)
            {
                manager_BroadcastsPlaybackPlanDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                manager_BroadcastsPlaybackPlanDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void fieldListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;
        }

        private void channelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (channelTextBox.Text != "")
            {
                manager_BroadcastsPlaybackPlanBindingSource.Filter = "[Внешний канал] Like '" + channelTextBox.Text + "%'";
            }
            else
            {
                manager_BroadcastsPlaybackPlanBindingSource.Filter = "";
            }
        }

        private void broadcastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.broadcastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }
    }
}
