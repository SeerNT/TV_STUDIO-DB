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
        public DirectorEditingForm()
        {
            InitializeComponent();
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

            titleTextBox.Text = Director_BroadcastPlaybackPlanForm.currentVideomaterialName;

        }

        private void ChangeExistBroadcast()
        {
            int videoID = (int)GetIDsCommand.Parameters["@video_id"].Value;
            int broadcastID = (int)GetIDsCommand.Parameters["@broadcast_id"].Value;
            DataRowView row = (DataRowView)categoryComboBox.SelectedItem;

            ChangeBroadcastCommand.Parameters["@video_id"].Value = videoID;
            ChangeBroadcastCommand.Parameters["@broadcast_id"].Value = broadcastID;
            ChangeBroadcastCommand.Parameters["@newTitle"].Value = titleTextBox.Text;
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
                if (titleTextBox.Text != "")
                {
                    if(channelTextBox.Text != "")
                    {
                        GetIDsCommand.Parameters["@title"].Value = Director_BroadcastPlaybackPlanForm.currentVideomaterialName;

                        sqlConnection1.Open();
                        GetIDsCommand.ExecuteNonQuery();
                        sqlConnection1.Close();

                        if (GetIDsCommand.Parameters["@broadcast_id"].Value.ToString() == "")
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

                            if(Director_BroadcastPlaybackPlanForm.currentVideomaterialName != titleTextBox.Text)
                            {
                                int videoID = (int)GetIDsCommand.Parameters["@video_id"].Value;
                                ChangeVideomaterialTitleCommand.Parameters["@video_id"].Value = videoID;
                                ChangeVideomaterialTitleCommand.Parameters["@newTitle"].Value = titleTextBox.Text;

                                ChangeVideomaterialTitleCommand.ExecuteNonQuery();

                                string result = (string)ChangeVideomaterialTitleCommand.Parameters["@res"].Value;

                                if (result != "GOOD")
                                {
                                    MessageBox.Show(
                                        "Не удалось найти видеоматериал связанный с новой трансляцеий",
                                        "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly
                                    );
                                    sqlConnection1.Close();
                                }
                                else
                                {
                                    AddBaseEventCommand.Parameters["@broadcastID"].Value = newBroadcastID;
                                    AddBaseEventCommand.Parameters["@videoTitle"].Value = titleTextBox.Text;

                                    AddBaseEventCommand.ExecuteNonQuery();

                                    sqlConnection1.Close();

                                    MessageBox.Show("Новая трансляция была добавлена",
                                    "Успешно", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                                    this.Close();
                                }
                            }
                            else
                            {
                                AddBaseEventCommand.Parameters["@broadcastID"].Value = newBroadcastID;
                                AddBaseEventCommand.Parameters["@videoTitle"].Value = Director_BroadcastPlaybackPlanForm.currentVideomaterialName;

                                AddBaseEventCommand.ExecuteNonQuery();

                                sqlConnection1.Close();

                                MessageBox.Show("Новая трансляция была добавлена",
                                "Успешно", MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                                this.Close();
                            }
                        }
                        else
                        {
                            ChangeExistBroadcast();
                        }
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
                else
                {
                    MessageBox.Show(
                            "Название трансляции не может быть пустым",
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
