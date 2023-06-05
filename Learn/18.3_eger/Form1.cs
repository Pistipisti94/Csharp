using System.Windows.Forms;

namespace _18._3_eger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("AzegérkoordinátáiX:{0},Y:{1}", e.X, e.Y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }
        private void PanelIgazit()
        { panel1.Left = (ClientSize.Width - panel1.Width) / 2;
          panel1.Top = (ClientSize.Height - panel1.Height) / 2; }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Location = new System.Drawing.Point(254, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 161);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(861, 466);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void PanelIgazit()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2; panel1.Top = (ClientSize.Height - panel1.Height) / 2; 
        }
    }
}