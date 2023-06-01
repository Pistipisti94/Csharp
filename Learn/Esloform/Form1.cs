namespace Esloform
{
    public partial class Pikachu : Form
    {
        public Pikachu()
        {
            InitializeComponent();
        }

        private void Pikachu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void szoroz_Click(object sender, EventArgs e)
        {
            if (osztoosszeg.Value < 1)
            {
                eredmeny.Text = "0-val nem lehet osztani";
            }
            else
            {
                eredmeny.Text = Convert.ToString(szorozosszeg.Value / osztoosszeg.Value);
            }
            
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }