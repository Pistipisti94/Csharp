using System;

namespace _18._7_komponensek
{
    public partial class Form1 : Form
    {
        Random rnd= new Random();
        double atlagg;
        int osszeg,db,minn=int.MaxValue,maxx=int.MinValue;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = rnd.Next(100) + 1;
            Label lb = new Label();
            lb.Location = new Point(e.X, e.Y);
            lb.Text = i.ToString();
            lb.AutoSize = true;
            Controls.Add(lb);
            db++; osszeg += i;
            atlagg = osszeg / (double)db;
            if (minn > i) { minn = i; }
            if (maxx < i) { maxx = i; }
            lb_Eredmeny.Text = String.Format("Darabszám: {0}, összeg: {1}, átlag: {2} ," + "minimum: {3}, maximum: {4}.", db, osszeg, atlagg, minn, maxx);

        }
    }
}
    
