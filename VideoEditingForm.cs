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
    public partial class VideoEditingForm : Form
    {
        private DirectorEditingForm directorEditingForm;
        private NewEvent newEventForm;
        private EditEvent editEventForm;
        public int broadcastID;
        //public int videoID;
        public int eventID;
        public TimeSpan baseTime;
        public int baseDuration;


        public VideoEditingForm(int broadcastID)
        {
            InitializeComponent();
            this.broadcastID = broadcastID;
        }

        public void UpdateTable()
        {
            this.eventTableAdapter.Fill(this.бД_ТелестудииDataSet.Event);
        }

        private void VideoEditingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.EventView". При необходимости она может быть перемещена или удалена.
            this.eventViewTableAdapter.Fill(this.бД_ТелестудииDataSet.EventView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.бД_ТелестудииDataSet.Event);

            eventBindingSource.Filter = "ID_Broadcast = " + broadcastID;
            eventViewBindingSource.Filter = "ID_Broadcast = " + broadcastID;
            
            broadcastTitleLabel.Text = BroadcastPlaybackPlanForm.currentVideomaterialName;
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }

        private void OpenAddEventForm()
        {
            if (newEventForm != null)
                newEventForm.Close();

            newEventForm = new NewEvent(this);
            newEventForm.Show();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            OpenAddEventForm();
        }

        private void eventDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(eventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                eventID = int.Parse(eventViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                baseTime = TimeSpan.Parse(eventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                baseDuration = (int)eventDataGridView.Rows[e.RowIndex].Cells[1].Value;

                if (editEventForm != null)
                    editEventForm.Close();

                editEventForm = new EditEvent(this);
                editEventForm.Show();
            }
        }

        private void eventBindingNavigator_Click(object sender, EventArgs e)
        {
            OpenAddEventForm();
        }
    }
}
