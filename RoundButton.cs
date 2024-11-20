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
    public partial class RoundButton : RoundControl
    {
        public string ButtonText { get => button1.Text; set => button1.Text = value; }
        public bool UseMouseOverBackColor { get; set; } = false;
        public Color OnClickBackColor { get; set; }
        public Color MouseOverBorderColor { get; set; }
        private Color backgroundColor;

        public RoundButton()
        {
            InitializeComponent();
        }

        private void RoundButton_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.BackColor = BackgroundColor;
            backgroundColor = BackgroundColor;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            button1.Location = new Point(20, 20);
            button1.Size = new Size(Size.Width - 40, Size.Height - 40);
            button1.BackColor = BackgroundColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this, e);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (UseMouseOverBackColor)
                BorderColor = MouseOverBorderColor;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (UseMouseOverBackColor)
                BorderColor = button1.BackColor = backgroundColor;
        }

        private void RoundButton_MouseEnter(object sender, EventArgs e)
        {
            button1_MouseEnter(sender, e);
        }

        private void RoundButton_MouseLeave(object sender, EventArgs e)
        {
            button1_MouseLeave(sender, e);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (UseMouseOverBackColor)
                BackgroundColor = button1.BackColor = OnClickBackColor;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (UseMouseOverBackColor)
                BackgroundColor = button1.BackColor = backgroundColor;
        }

        private void RoundButton_MouseDown(object sender, MouseEventArgs e)
        {
            button1_MouseDown(sender, e);
        }

        private void RoundButton_MouseUp(object sender, MouseEventArgs e)
        {
            button1_MouseUp(sender, e);
        }
    }
}
