using System.Windows.Forms;

namespace _18._3_egerxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("AzegérkoordinátáiX:{0},Y:{1}", e.X, e.Y);
        }
        private void PanelIgazit()
        {
            panel.Left = (ClientSize.Width - panel.Width) / 2;
            panel.Top = (ClientSize.Height - panel.Height) / 2;
        }
    }
}