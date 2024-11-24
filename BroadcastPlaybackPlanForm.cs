using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_Телестудии
{
    public partial class BroadcastPlaybackPlanForm : Form
    {
        public static string currentVideomaterialName;
        private EditorProgressForm editorProgressForm;

        private int broadcastID;


        public BroadcastPlaybackPlanForm()
        {
            InitializeComponent();
        }

        public void UpdateTable()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Video_Editing". При необходимости она может быть перемещена или удалена.
            this.video_EditingTableAdapter.Fill(this.бД_ТелестудииDataSet.Video_Editing);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
        }

        private void BroadcastPlaybackPlanForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Video_Editing". При необходимости она может быть перемещена или удалена.
            this.video_EditingTableAdapter.Fill(this.бД_ТелестудииDataSet.Video_Editing);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
        }

        private void BroadcastPlaybackPlanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openProgressButton_Click(object sender, EventArgs e)
        {
            if (editorProgressForm != null)
                editorProgressForm.Close();

            editorProgressForm = new EditorProgressForm();
            editorProgressForm.Show();
        }

        private void broadcastsPlaybackPlanDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if (broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    broadcastID = int.Parse(broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                        Cells[0].Value.ToString());

                    new VideoEditingForm(broadcastID, this).Show();
                }
            }
        }

        private void broadcastsPlaybackPlanDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    broadcastID = int.Parse(broadcastsPlaybackPlanDataGridView.Rows[e.RowIndex].
                        Cells[0].Value.ToString());
                    
                    video_EditingBindingSource.Filter = "ID_Editing = " +
                        broadcastID;
                } 
            }
        }

        private void changePropButton_Click(object sender, EventArgs e)
        {
            ChangeVideomaterialPropsCommand.Parameters["@broadcastID"].Value =
                broadcastID;
            ChangeVideomaterialPropsCommand.Parameters["@newFramerate"].Value =
                framerateNumericUpDown.Value;
            ChangeVideomaterialPropsCommand.Parameters["@newAuthor"].Value = authorTextBox.Text;

            sqlConnection1.Open();

            ChangeVideomaterialPropsCommand.ExecuteNonQuery();
            // закрыть соединение с БД
            sqlConnection1.Close();

            MessageBox.Show("Видеоматериал был изменен",
                "Успешно", MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            UpdateTable();
        }

        private void authorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[.]").Success
                && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
