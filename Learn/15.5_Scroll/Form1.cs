namespace _15._5_Scroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Lb_Oldal_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value, SB_Zold.Value, SB_Kek.Value);
        }

        private void SB_Zold_Scroll(object sender, ScrollEventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value, SB_Zold.Value, SB_Kek.Value);

        }

        private void SB_Kek_Scroll(object sender, ScrollEventArgs e)
        {
            Lb_Negyzet.BackColor = Color.FromArgb(Sb_Piros.Value, SB_Zold.Value, SB_Kek.Value);

        }

        private void Sb_Oldal_ValueChanged(object sender, EventArgs e)
        {
            Lb_Negyzet.Width = Lb_Negyzet.Height = Sb_Oldal.Value;
            Lb_Oldal.Text = Sb_Oldal.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}