using System;

namespace _18._7_komponensek
{
    public partial class Form1 : Form
    {
        Random rnd= new Random();
        double atlagg;
        int osszeg,db,minn=int.MaxValue,maxx=int.MinValue;
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
            atlag = osszegg / (double)db;
            if (minn > i) min = i;
            if (maxx < i) max = i;
        }
    }
}