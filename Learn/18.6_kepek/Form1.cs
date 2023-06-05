namespace _18._6_kepek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Bal_Click(object sender, EventArgs e)
        {
            Image S = K1.BackgroundImage;
            K1.BackgroundImage = K2.BackgroundImage;
            K2.BackgroundImage = K3.BackgroundImage;
            K3.BackgroundImage = K4.BackgroundImage;
            K4.BackgroundImage = K5.BackgroundImage;
            K5.BackgroundImage = K6.BackgroundImage;
            K6.BackgroundImage = K7.BackgroundImage;
            K7.BackgroundImage = K8.BackgroundImage;
            K8.BackgroundImage = S;

        }

        private void Bt_Jobb_Click(object sender, EventArgs e)
        {
            Image S = K8.BackgroundImage;
            K8.BackgroundImage = K7.BackgroundImage;
            K7.BackgroundImage = K6.BackgroundImage;
            K6.BackgroundImage = K5.BackgroundImage;
            K5.BackgroundImage = K4.BackgroundImage;
            K4.BackgroundImage = K3.BackgroundImage;
            K3.BackgroundImage = K2.BackgroundImage;
            K2.BackgroundImage = K1.BackgroundImage;
            K1.BackgroundImage = S;
        }
    }
}