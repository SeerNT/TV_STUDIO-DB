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
        public NewEvent()
        {
            InitializeComponent();
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.Videomaterial". При необходимости она может быть перемещена или удалена.
            this.videomaterialTableAdapter.Fill(this.бД_ТелестудииDataSet.Videomaterial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.BroadcastsPlaybackPlan". При необходимости она может быть перемещена или удалена.
            this.broadcastsPlaybackPlanTableAdapter.Fill(this.бД_ТелестудииDataSet.BroadcastsPlaybackPlan);

        }
    }
}
