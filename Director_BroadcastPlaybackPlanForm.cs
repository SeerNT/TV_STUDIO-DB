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
        private DirectorEditingForm directorEditingForm;

        public string category;
        public string channel;
        public DateTime date;
        public int broadcastID;

        public Director_BroadcastPlaybackPlanForm()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            this.director_BroadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.Director_BroadcastsPlaybackPlan);
        }

        private void BroadcastPlaybackPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Director_BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.director_BroadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.Director_BroadcastsPlaybackPlan);
        }

        private void BroadcastPlaybackPlanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addBroadcastButton_Click(object sender, EventArgs e)
        {
            if (directorEditingForm != null)
                directorEditingForm.Close();

            directorEditingForm = new DirectorEditingForm(this);
            directorEditingForm.mode = 2;
            directorEditingForm.Show();
        }

        private void director_BroadcastsPlaybackPlanDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (director_BroadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                broadcastID = int.Parse(director_BroadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                    Cells[0].Value.ToString());

                category = director_BroadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                    Cells[1].Value.ToString();

                channel = director_BroadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                    Cells[2].Value.ToString();

                date = DateTime.Parse(director_BroadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                    Cells[3].Value.ToString());

                if (directorEditingForm != null)
                    directorEditingForm.Close();

                directorEditingForm = new DirectorEditingForm(this);
                directorEditingForm.mode = 1;
                directorEditingForm.Show();
            }
        }
    }
}
