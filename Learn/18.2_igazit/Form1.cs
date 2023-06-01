namespace _18._2_igazit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void label_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (label.Width / 3);
            int m = e.Y / (label.Height / 3);
            switch (m * 3 + n)
            {
                case 0:
                    label.TextAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    label.TextAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    label.TextAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    label.TextAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    label.TextAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    label.TextAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    label.TextAlign = ContentAlignment.BottomRight;
                    break;
            }
        }
    }
}