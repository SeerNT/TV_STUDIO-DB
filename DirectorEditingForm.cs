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
    public partial class DirectorEditingForm : Form
    {
        private Director_BroadcastPlaybackPlanForm dirForm;
        public int mode = -1;

        public DirectorEditingForm(Director_BroadcastPlaybackPlanForm dirForm)
        {
            InitializeComponent();
            this.dirForm = dirForm;
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }

        private void categoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_ТелестудииDataSet);

        }

        private void DirectorEditingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.бД_ТелестудииDataSet.Category);

            if (mode == 2)
            {
                changeBroadcastButton.ButtonText = "Добавить";

                categoryComboBox.SelectedIndex = 0;
                channelTextBox.Text = "";
                playDate.Value = DateTime.Today;
            }
            else if (mode == 1)
            {
                changeBroadcastButton.ButtonText = "Изменить";

                categoryComboBox.SelectedIndex = categoryComboBox.FindStringExact(dirForm.category);
                channelTextBox.Text = dirForm.channel;
                playDate.Value = dirForm.date;
            }
        }

        private void AddBroadcast()
        {
            sqlConnection1.Open();
            GetLastBroadcastIdCommand.ExecuteNonQuery();

            DataRowView row = (DataRowView)categoryComboBox.SelectedItem;

            int newBroadcastID = (int)GetLastBroadcastIdCommand.Parameters["@last_id"].Value + 1;

            AddNewBroadcastCommand.Parameters["@broadcast_id"].Value = newBroadcastID;
            AddNewBroadcastCommand.Parameters["@category"].Value = row.Row[1].ToString();
            AddNewBroadcastCommand.Parameters["@channel"].Value = channelTextBox.Text;
            AddNewBroadcastCommand.Parameters["@play_date"].Value = playDate.Value;

            AddNewBroadcastCommand.ExecuteNonQuery();

            //AddBaseEventCommand.Parameters["@broadcastID"].Value = newBroadcastID;
            //AddBaseEventCommand.Parameters["@videoTitle"].Value = Director_BroadcastPlaybackPlanForm.currentVideomaterialName;

            //AddBaseEventCommand.ExecuteNonQuery();

            sqlConnection1.Close();

            MessageBox.Show("Новая трансляция была добавлена",
            "Успешно", MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
            this.Close();
        }

        private void ChangeExistBroadcast()
        {
            DataRowView row = (DataRowView)categoryComboBox.SelectedItem;

            ChangeBroadcastCommand.Parameters["@broadcast_id"].Value = dirForm.broadcastID;
            ChangeBroadcastCommand.Parameters["@category"].Value = row.Row[1].ToString();
            ChangeBroadcastCommand.Parameters["@channel"].Value = channelTextBox.Text;
            ChangeBroadcastCommand.Parameters["@playDate"].Value = playDate.Value;

            sqlConnection1.Open();
            ChangeBroadcastCommand.ExecuteNonQuery();
            sqlConnection1.Close();

            string result = (string)ChangeBroadcastCommand.Parameters["@res"].Value;

            if (result == "GOOD")
            {
                MessageBox.Show("Трансляция была изменена",
                "Успешно", MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

                this.Close();
            }
        }

        private void changeBroadcastButton_Click(object sender, EventArgs e)
        {
            if(playDate.Value < DateTime.Today)
            {
                MessageBox.Show(
                        "Дата воспроизведения трансляции должна быть больше или равна текущей даты",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                    );
            }
            else
            {
                if (channelTextBox.Text != "")
                {
                    if(mode == 2)
                    {
                        AddBroadcast();
                    }
                    else if(mode == 1)
                    {
                        ChangeExistBroadcast();
                    }
                    dirForm.UpdateTable();
                }
                else
                {
                    MessageBox.Show(
                            "Название канала не может быть пустым",
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
}
