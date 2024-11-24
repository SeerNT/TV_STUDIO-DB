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
    public partial class EditEvent : Form
    {
        private VideoEditingForm editForm;
        private BroadcastPlaybackPlanForm mainForm;

        public EditEvent(VideoEditingForm editForm)
        {
            
            InitializeComponent();
            this.editForm = editForm;
            this.mainForm = editForm.mainForm;
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.бД_ТелестудииDataSet.Event);

            GetEventInfoCommand.Parameters["@eventID"].Value = editForm.eventID;

            sqlConnection1.Open();

            GetEventInfoCommand.ExecuteNonQuery();

            TimeSpan startTime = (TimeSpan)GetEventInfoCommand.Parameters["@startTime"].Value;

            startTimePicker.Value = new DateTime(2022, 1, 1, startTime.Hours, startTime.Minutes, startTime.Seconds);

            int duration = (int)GetEventInfoCommand.Parameters["@duration"].Value;

            durationUpDown.Value = duration;

            if (GetEventInfoCommand.Parameters["@transitionType"].Value != DBNull.Value)
            {
                string transitionType = (string)GetEventInfoCommand.Parameters["@transitionType"].Value;
                transitionTypeComboBox.SelectedIndex = transitionTypeComboBox.FindStringExact(transitionType);
            }
            if (GetEventInfoCommand.Parameters["@transitionDuration"].Value != DBNull.Value)
            {
                int transitionDuration = (int)GetEventInfoCommand.Parameters["@transitionDuration"].Value;
                transitionDurationUpDown.Value = transitionDuration;
            }
            if (GetEventInfoCommand.Parameters["@transitionDelay"].Value != DBNull.Value)
            {
                int transitionDelay = (int)GetEventInfoCommand.Parameters["@transitionDelay"].Value;
                transitionDelayUpDown.Value = transitionDelay;
            }
            if (GetEventInfoCommand.Parameters["@description"].Value != DBNull.Value)
            {
                string description = (string)GetEventInfoCommand.Parameters["@description"].Value;
                descriptionTextBox.Text = description;
            }
            if (GetEventInfoCommand.Parameters["@recSource"].Value != DBNull.Value)
            {
                string recSource = (string)GetEventInfoCommand.Parameters["@recSource"].Value;
                recSourceTextBox.Text = recSource;
            }

            videoComboBox.SelectedIndex = videoComboBox.FindStringExact(
                (string)GetEventInfoCommand.Parameters["@videoTitle"].Value);

            sqlConnection1.Close();
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            if((transitionTypeComboBox.SelectedItem == null || transitionTypeComboBox.SelectedIndex == 4) 
                && (transitionDurationUpDown.Value != 0 || transitionDelayUpDown.Value != 0))
            {
                MessageBox.Show("Длительность и задержка перехода не может быть задана без вида перехода",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            else
            {
                ChangeEventCommand.Parameters["@eventID"].Value = editForm.eventID;

                TimeSpan ts = TimeSpan.FromSeconds(startTimePicker.Value.Second
                    + startTimePicker.Value.Minute * 60 + startTimePicker.Value.Hour * 60 * 60);

                ChangeEventCommand.Parameters["@startTime"].Value = ts;
                ChangeEventCommand.Parameters["@duration"].Value = durationUpDown.Value;

                if (transitionTypeComboBox.SelectedItem != null &&
                    transitionTypeComboBox.SelectedItem.ToString() != "Нет")
                {
                    ChangeEventCommand.Parameters["@transitionType"].Value =
                        transitionTypeComboBox.SelectedItem.ToString();

                    ChangeEventCommand.Parameters["@transitionDuration"].Value =
                        transitionDurationUpDown.Value;
                    ChangeEventCommand.Parameters["@transitionDelay"].Value =
                        transitionDelayUpDown.Value;
                }
                else
                {
                    ChangeEventCommand.Parameters["@transitionType"].Value =
                        DBNull.Value;
                    ChangeEventCommand.Parameters["@transitionDuration"].Value =
                        DBNull.Value;
                    ChangeEventCommand.Parameters["@transitionDelay"].Value =
                        DBNull.Value;
                }

                if (descriptionTextBox.Text != "")
                {
                    ChangeEventCommand.Parameters["@description"].Value =
                        descriptionTextBox.Text;
                }
                else
                {
                    ChangeEventCommand.Parameters["@description"].Value =
                        DBNull.Value;
                }

                if (recSourceTextBox.Text != "")
                {
                    ChangeEventCommand.Parameters["@recSource"].Value =
                        recSourceTextBox.Text;
                }
                else
                {
                    ChangeEventCommand.Parameters["@recSource"].Value =
                       DBNull.Value;
                }

                UpdateVideoEditingSumDurationCommand.Parameters["@broadcastID"].Value = 
                    editForm.broadcastID;
                UpdateVideoEditingSumDurationCommand.Parameters["@eventID"].Value =
                   editForm.eventID;

                DataRowView row = (DataRowView)videoComboBox.SelectedItem;

                ChangeEventCommand.Parameters["@videoID"].Value = row.Row[0].ToString();

                sqlConnection1.Open();

                ChangeEventCommand.ExecuteNonQuery();

                UpdateVideoEditingSumDurationCommand.Parameters["@editingID"].Value =
                   ChangeEventCommand.Parameters["@editingID"].Value;

                UpdateVideoEditingSumDurationCommand.ExecuteNonQuery();

                sqlConnection1.Close();

                MessageBox.Show("Событие было изменено",
                        "Успешно", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                editForm.UpdateTable();
                mainForm.UpdateTable();

                this.Close();
            }
        }

        private void transitionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(transitionTypeComboBox.SelectedIndex == 4) {
                transitionDurationUpDown.Value = 0;
                transitionDelayUpDown.Value = 0;
            }
        }
    }
}
