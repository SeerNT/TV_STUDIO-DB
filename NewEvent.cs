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
    public partial class NewEvent : Form
    {
        private VideoEditingForm editForm;

        public NewEvent(VideoEditingForm editForm)
        {
            InitializeComponent();
            this.editForm = editForm;
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if ((transitionTypeComboBox.SelectedItem == null || transitionTypeComboBox.SelectedIndex == 4)
                            && (transitionDurationUpDown.Value != 0 || transitionDelayUpDown.Value != 0))
            {
                MessageBox.Show("Длительность и задержка перехода не может быть задана без вида перехода",
                        "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            else
            {
                AddNewEventCommand.Parameters["@broadcastID"].Value = editForm.broadcastID;

                DataRowView row = (DataRowView)videoComboBox.SelectedItem;
                AddNewEventCommand.Parameters["@videoID"].Value = row.Row[0];

                TimeSpan ts = TimeSpan.FromSeconds(startTimePicker.Value.Second
                    + startTimePicker.Value.Minute * 60 + startTimePicker.Value.Hour * 60 * 60);

                AddNewEventCommand.Parameters["@startTime"].Value = ts;
                AddNewEventCommand.Parameters["@duration"].Value = durationUpDown.Value;


                if (transitionTypeComboBox.SelectedItem != null &&
                    transitionTypeComboBox.SelectedItem.ToString() != "Нет")
                {
                    AddNewEventCommand.Parameters["@transitionType"].Value =
                        transitionTypeComboBox.SelectedItem.ToString();

                    AddNewEventCommand.Parameters["@transitionDuration"].Value =
                        transitionDurationUpDown.Value;
                    AddNewEventCommand.Parameters["@transitionDelay"].Value =
                        transitionDelayUpDown.Value;
                }
                else
                {
                    AddNewEventCommand.Parameters["@transitionType"].Value =
                        DBNull.Value;
                    AddNewEventCommand.Parameters["@transitionDuration"].Value =
                        DBNull.Value;
                    AddNewEventCommand.Parameters["@transitionDelay"].Value =
                        DBNull.Value;
                }

                if (descriptionTextBox.Text != "")
                {
                    AddNewEventCommand.Parameters["@description"].Value =
                        descriptionTextBox.Text;
                }
                else
                {
                    AddNewEventCommand.Parameters["@description"].Value =
                        DBNull.Value;
                }

                if (recSourceTextBox.Text != "")
                {
                    AddNewEventCommand.Parameters["@recSource"].Value =
                        recSourceTextBox.Text;
                }
                else
                {
                    AddNewEventCommand.Parameters["@recSource"].Value =
                       DBNull.Value;
                }

                UpdateVideoEditingSumDurationCommand.Parameters["@broadcastID"].Value =
                   editForm.broadcastID;
                UpdateVideoEditingSumDurationCommand.Parameters["@eventID"].Value =
                   editForm.eventID;

                sqlConnection1.Open();

                AddNewEventCommand.ExecuteNonQuery();

                UpdateVideoEditingSumDurationCommand.Parameters["@editingID"].Value =
                   editForm.broadcastID;

                UpdateVideoEditingSumDurationCommand.ExecuteNonQuery();

                sqlConnection1.Close();


                MessageBox.Show("Событие было добавлено",
                        "Успешно", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                editForm.UpdateTable();
                this.Close();
            }
        }

        private void transitionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transitionTypeComboBox.SelectedIndex == 4)
            {
                transitionDurationUpDown.Value = 0;
                transitionDelayUpDown.Value = 0;
            }
        }
    }
}
