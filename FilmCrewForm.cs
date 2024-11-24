using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using БД_Телестудии.БД_ТелестудииDataSetTableAdapters;


namespace БД_Телестудии
{
    public partial class FilmCrewForm : Form
    {
        private string fileComment;
        private DateTime fileDate;

        private short lastVideomaterialID;

        private bool isLogOut = false;

        public FilmCrewForm()
        {
            InitializeComponent();
        }

        private void videomaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videomaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DB_TVStudioDataSet);

        }

        public void UpdateTable()
        {
            this.videomaterialTableAdapter.Fill(this.DB_TVStudioDataSet.Videomaterial);
        }

        private void FilmCrewForm_Load(object sender, EventArgs e)
        {
            isLogOut = false;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.DB_TVStudioDataSet.Videomaterial);

            int lastRowNum = DB_TVStudioDataSet.Videomaterial.Rows.Count - 1;
            lastVideomaterialID = (short)DB_TVStudioDataSet.Videomaterial.Rows[lastRowNum].ItemArray[0];
        }

        private void FilmCrewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogOut)
            {
                Application.Exit();
            }
            else
            {
                if (Program.openForms.All(f => f == null))
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            videoDateTimePicker.Enabled = true;
            videoDescTextBox.Enabled = true;

            fileDate = DateTime.Now;
            videoDateTimePicker.Value = fileDate;

            FileInfo videoFileInfo = new FileInfo(openFileDialog1.FileName);

            Shell32.Shell app = new Shell32.Shell();
            Shell32.Folder dir = app.NameSpace(videoFileInfo.DirectoryName);
            Shell32.FolderItem itm = dir.Items().Item(openFileDialog1.SafeFileName);
            Shell32.ShellFolderItem itm2 = (Shell32.ShellFolderItem)itm;

            fileComment = (string)itm2.ExtendedProperty("{F29F85E0-4FF9-1068-AB91-08002B27B3D9} 6");

            videoDescTextBox.Text = fileComment;
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            if(videoDescTextBox.Text != null)
            {
                lastVideomaterialID++;
                videomaterialTableAdapter.Insert((short)(lastVideomaterialID), videoDescTextBox.Text, fileDate);
                MessageBox.Show("Видеоматериал добавлен",
                    "Успешно", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
               );
            }

            UpdateTable();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Program.authForm = new Authorization();
            Program.authForm.Show();

            isLogOut = true;

            this.Close();
        }
    }
}
