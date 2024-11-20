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
    public partial class VideoEditingForm : Form
    {
        private DirectorEditingForm directorEditingForm;
        private NewEvent newEventForm;
        private EditEvent editEventForm;
        public int broadcastID;
        public int videoID;
        public TimeSpan baseTime;
        public int baseDuration;

        public VideoEditingForm()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            this.eventTableAdapter.Fill(this.бД_ТелестудииDataSet.Event);
        }

        private void VideoEditingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.бД_ТелестудииDataSet.Event);

            GetBroadcastAndVideoIDByTitleCommand.Parameters["@title"].Value = 
                BroadcastPlaybackPlanForm.currentVideomaterialName;

            sqlConnection1.Open();

            GetBroadcastAndVideoIDByTitleCommand.ExecuteNonQuery();

            broadcastID = (int)GetBroadcastAndVideoIDByTitleCommand.Parameters["@broadcast_id"].Value;
            videoID = (int)GetBroadcastAndVideoIDByTitleCommand.Parameters["@video_id"].Value;

            eventBindingSource.Filter = "ID_Broadcast = " + broadcastID;

            //DataGridRow row = eventBindingSource.ro;
            //Console.WriteLine(row.Row[0].ToString());
            sqlConnection1.Close();
            
            broadcastTitleLabel.Text = BroadcastPlaybackPlanForm.currentVideomaterialName;
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            if (newEventForm != null)
                newEventForm.Close();

            newEventForm = new NewEvent();
            newEventForm.Show();
        }

        private void eventDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(eventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                baseTime = TimeSpan.Parse(eventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                baseDuration = (int)eventDataGridView.Rows[e.RowIndex].Cells[1].Value;

                if (editEventForm != null)
                    editEventForm.Close();

                editEventForm = new EditEvent(this);
                editEventForm.Show();
            }
        }
    }
}
