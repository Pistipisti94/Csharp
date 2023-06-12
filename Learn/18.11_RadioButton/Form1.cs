namespace _18._11_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int LNKO(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
                return LNKO(a % b, b);
            else
                return LNKO(a, b % a);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            // Adatok ellenõrzése számítás elõtt 

            if (!int.TryParse(TBx_A.Text, out a))
            {
                MessageBox.Show("Nem megfelelõ szám!");
                TBx_A.Text = String.Empty;
                TBx_A.Focus();
                return;
            }

            if (!int.TryParse(TBx_B.Text, out b))
            {
                MessageBox.Show("Nem megfelelõ szám!");
                TBx_B.Text = String.Empty;
                TBx_B.Focus();
                return;
            }

            if (Rb_LNKO.Checked)
            {
                MessageBox.Show(String.Format(
                   "A két szám legnagyobb közös osztója: {0}",
                   LNKO(a, b)));
            }
            else
            {
                MessageBox.Show(String.Format(
                   "A két szám legkisebb közös többszöröse: {0}",
                   (a * b) / LNKO(a, b)));
            }
        }
    }
}