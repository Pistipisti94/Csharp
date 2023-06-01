namespace Aimlab
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void celpont_Click(object sender, EventArgs e)
        {
            Random rndx = new Random();
            Random rndy = new Random();
            celpont.Location = new Point(rndx.Next(1,800), rndy.Next(1,800));
        }
    }
}