namespace _18._1_ugrik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbalfel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnjobbfel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width; 
            Top = 0;
        }

        private void btnballe_Click(object sender, EventArgs e)
        {
            Left = 0; 
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnjobble_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width; 
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}