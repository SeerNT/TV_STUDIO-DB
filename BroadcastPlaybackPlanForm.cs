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
    public partial class BroadcastPlaybackPlanForm : Form
    {
        public static string currentVideomaterialName;
        private EditorProgressForm editorProgressForm;
        private VideomaterialProperty videomaterialPropertyForm;

        private int broadcastID;


        public BroadcastPlaybackPlanForm()
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
            
        }

        private void detailedTableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.broadcastsPlaybackPlan_DetailedTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan_Detailed);
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);

            if (detailedTableCheckBox.Checked)
            {
                ShowBroadcastsPlan_Detailed();
            }
            else
            {
                ShowBroadcastsPlan();
            }
        }

        private void openProgressButton_Click(object sender, EventArgs e)
        {
            if (editorProgressForm != null)
                editorProgressForm.Close();

            editorProgressForm = new EditorProgressForm();
            editorProgressForm.Show();
        }

        private void propOpenButton_Click(object sender, EventArgs e)
        {
            if (videomaterialPropertyForm != null)
                videomaterialPropertyForm.Close();

            videomaterialPropertyForm = new VideomaterialProperty();
            videomaterialPropertyForm.Show();
        }

        private void broadcastsPlaybackPlanDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                broadcastID = int.Parse(broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                new VideoEditingForm(broadcastID).Show();
            }
        }

        private void broadcastsPlaybackPlan_DetailedDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (broadcastsPlaybackPlan_DetailedDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                broadcastID = int.Parse(broadcastsPlaybackPlan_DetailedDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                new VideoEditingForm(broadcastID).Show();
            }
        }
    }
}
