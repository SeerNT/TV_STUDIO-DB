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
    public partial class EditorProgressForm : Form
    {
        public EditorProgressForm()
        {
            InitializeComponent();
        }

        private void EditorProgressForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.UsedVideomaterials". При необходимости она может быть перемещена или удалена.
            this.usedVideomaterialsTableAdapter.Fill(this.бД_ТелестудииDataSet.UsedVideomaterials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ТелестудииDataSet.UnusedVideomaterials". При необходимости она может быть перемещена или удалена.
            this.unusedVideomaterialsTableAdapter.Fill(this.бД_ТелестудииDataSet.UnusedVideomaterials);

        }
    }
}
