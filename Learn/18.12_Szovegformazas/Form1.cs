namespace _18._12_Szovegformazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FontBeallit()
        {
            Lb_Proba.Font = new Font(GetFontName(),
               (int)NDD_Fontmeret.Value, GetFontStyle());
        }

        private FontStyle GetFontStyle()
        {
            FontStyle result = FontStyle.Regular;
            if (Cbx_Alahuz.Checked)
                result |= FontStyle.Underline;
            if (Cbx_Dolt.Checked)
                result |= FontStyle.Italic;
            if (Cbx_Felk.Checked)
                result |= FontStyle.Bold;
            return result;
        }

        private string GetFontName()
        {
            if (Rb_Arial.Checked)
                return Rb_Arial.Text;
            else if (Rb_CS.Checked)
                return Rb_CS.Text;
            else if (Rb_TNR.Checked)
                return Rb_TNR.Text;
            return String.Empty;
        }
        private Color SzinBeallit()
        {
            return Color.FromArgb(
               Cbx_Piros.Checked ? 255 : 0,
               Cbx_Zold.Checked ? 255 : 0,
               Cbx_Kek.Checked ? 255 : 0
            );
        }

        private void Comb_Mit_SelectedIndexChanged(object sender, EventArgs e)
        {
            GB_Font.Enabled = GB_Stilus.Enabled = NDD_Fontmeret.Enabled =
               (Comb_Mit.SelectedIndex == 0);
            CheckBoxokBeallit((Comb_Mit.SelectedIndex == 0) ?
               Lb_Proba.ForeColor : Lb_Proba.BackColor);
        }
    }
}