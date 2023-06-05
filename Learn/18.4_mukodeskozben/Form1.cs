namespace _18._4_mukodeskozben
{
    public partial class Form1 : Form
    {
        private int meretezo = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0) 
            { 
                Top -= meretezo; 
            } 
            else 
            { 
                Top = 0; Bt_Fel.Visible = Bt_Fel_T.Visible = false; 
            }
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }

        private void K_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Bt_Le.Visible = Bt_Le_T.Visible = Bt_Fel.Visible = Bt_Fel_T.Visible = Bt_Bal.Visible = Bt_Bal_T.Visible = Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Width -= meretezo;
            Height -= meretezo;
        }

        private void button12_Click(object sender, EventArgs e)
        {
  
        }

        private void Bt_Fel_T_Click(object sender, EventArgs e)
        {
            Top = 0; 
            Bt_Fel.Visible = Bt_Fel_T.Visible = false;
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }

        private void Atlatszo_no_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0) Opacity += 0.1;
        }

        private void Atlatszosag_csokken_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.1) Opacity -= 0.1;
        }

        private void Bt_Fel_Click(object sender, EventArgs e)
        {
            Top = Top - 1;
            if (Top == 0)
            {
                Bt_Fel.Visible = Bt_Fel_T.Visible = false;
            }
            Bt_Le.Visible = Bt_Le_T.Visible = true;
        }

        private void Bt_Le_T_Click(object sender, EventArgs e)
        {
            Top = (Screen.PrimaryScreen.Bounds.Height - Height);
            Bt_Fel.Visible = Bt_Fel_T.Visible = true;
            Bt_Le.Visible = Bt_Le_T.Visible = false;
        }

        private void Bt_Jobb_T_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width);
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = false;
            Bt_Bal.Visible = Bt_Bal_T.Visible = true;
        }

        private void Bt_Bal_T_Click(object sender, EventArgs e)
        {
            Left = 0;
            Bt_Bal.Visible = Bt_Bal_T.Visible = false;
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;
        }

        private void Bt_meret_no_Click(object sender, EventArgs e)
        {
            Width += meretezo;
            Height += meretezo;
        }

        private void Bt_Le_Click(object sender, EventArgs e)
        {
            Top += 1;
            if (Top == (Screen.PrimaryScreen.Bounds.Height - Height))
            {
                Bt_Le.Visible = Bt_Le_T.Visible = false;
            }
            Bt_Fel.Visible = Bt_Fel_T.Visible = true;
        }

        private void Bt_Bal_Click(object sender, EventArgs e)
        {
            Left -= 1;
            if(Left == 0)
            {
                Bt_Bal.Visible = Bt_Bal_T.Visible = false;
            }
            Bt_Jobb.Visible = Bt_Jobb_T.Visible = true;

        }

        private void Bt_Jobb_Click(object sender, EventArgs e)
        {
            Left += 1;
            if (Left == (Screen.PrimaryScreen.Bounds.Width - Width))
            {
                Bt_Jobb.Visible = Bt_Jobb_T.Visible = false;
            }
            Bt_Bal.Visible = Bt_Bal_T.Visible = true;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}