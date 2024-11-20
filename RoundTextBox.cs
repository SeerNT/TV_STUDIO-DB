using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace БД_Телестудии
{
    public partial class RoundTextBox : RoundControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get => textBox2.Text; set => textBox2.Text = value; }
        public override Color ForeColor { get => textBox2.ForeColor; set => textBox2.ForeColor = value; }
        private Font _Font = UserControl.DefaultFont;
        [Description("Sets the font of the button caption")]
        [Browsable(true)]
        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get { return base.Font; }
            set { textBox2.Font = base.Font = value; }
        }

        public bool UseSystemPasswordChar { get; set; } = false;

        public RoundTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            textBox2.Location = new Point(Radius + 7, Radius + 7);
            textBox2.Size = new Size(Width - ((Radius + 7) * 2), Height - ((Radius + 7) * 2));
            textBox2.BackColor = BackgroundColor;
        }

        private void RoundTextBox_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = UseSystemPasswordChar;
        }
    }
}
