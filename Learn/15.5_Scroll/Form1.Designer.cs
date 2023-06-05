namespace _15._5_Scroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sb_Oldal = new System.Windows.Forms.HScrollBar();
            this.Sb_Piros = new System.Windows.Forms.HScrollBar();
            this.SB_Zold = new System.Windows.Forms.HScrollBar();
            this.SB_Kek = new System.Windows.Forms.HScrollBar();
            this.Lb_Negyzet = new System.Windows.Forms.Panel();
            this.szoveg = new System.Windows.Forms.Label();
            this.Lb_Oldal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sb_Oldal
            // 
            this.Sb_Oldal.Location = new System.Drawing.Point(271, 69);
            this.Sb_Oldal.Maximum = 309;
            this.Sb_Oldal.Minimum = 10;
            this.Sb_Oldal.Name = "Sb_Oldal";
            this.Sb_Oldal.Size = new System.Drawing.Size(300, 20);
            this.Sb_Oldal.TabIndex = 0;
            this.Sb_Oldal.Value = 309;
            this.Sb_Oldal.ValueChanged += new System.EventHandler(this.Sb_Oldal_ValueChanged);
            // 
            // Sb_Piros
            // 
            this.Sb_Piros.Location = new System.Drawing.Point(128, 460);
            this.Sb_Piros.Name = "Sb_Piros";
            this.Sb_Piros.Size = new System.Drawing.Size(600, 20);
            this.Sb_Piros.TabIndex = 0;
            this.Sb_Piros.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // SB_Zold
            // 
            this.SB_Zold.Location = new System.Drawing.Point(128, 490);
            this.SB_Zold.Name = "SB_Zold";
            this.SB_Zold.Size = new System.Drawing.Size(600, 20);
            this.SB_Zold.TabIndex = 0;
            this.SB_Zold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_Zold_Scroll);
            // 
            // SB_Kek
            // 
            this.SB_Kek.Location = new System.Drawing.Point(128, 521);
            this.SB_Kek.Name = "SB_Kek";
            this.SB_Kek.Size = new System.Drawing.Size(600, 20);
            this.SB_Kek.TabIndex = 0;
            this.SB_Kek.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_Kek_Scroll);
            // 
            // Lb_Negyzet
            // 
            this.Lb_Negyzet.BackColor = System.Drawing.SystemColors.Control;
            this.Lb_Negyzet.Location = new System.Drawing.Point(271, 118);
            this.Lb_Negyzet.Name = "Lb_Negyzet";
            this.Lb_Negyzet.Size = new System.Drawing.Size(300, 300);
            this.Lb_Negyzet.TabIndex = 1;
            this.Lb_Negyzet.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // szoveg
            // 
            this.szoveg.AutoSize = true;
            this.szoveg.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.szoveg.Location = new System.Drawing.Point(346, 31);
            this.szoveg.Name = "szoveg";
            this.szoveg.Size = new System.Drawing.Size(65, 21);
            this.szoveg.TabIndex = 2;
            this.szoveg.Text = "Oldala:";
            this.szoveg.TextChanged += new System.EventHandler(this.Lb_Oldal_TextChanged);
            // 
            // Lb_Oldal
            // 
            this.Lb_Oldal.AutoSize = true;
            this.Lb_Oldal.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Oldal.Location = new System.Drawing.Point(429, 31);
            this.Lb_Oldal.Name = "Lb_Oldal";
            this.Lb_Oldal.Size = new System.Drawing.Size(40, 21);
            this.Lb_Oldal.TabIndex = 3;
            this.Lb_Oldal.Text = "300";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Piros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zöld";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kék";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bezár";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Oldal);
            this.Controls.Add(this.szoveg);
            this.Controls.Add(this.Lb_Negyzet);
            this.Controls.Add(this.SB_Kek);
            this.Controls.Add(this.SB_Zold);
            this.Controls.Add(this.Sb_Piros);
            this.Controls.Add(this.Sb_Oldal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar Sb_Oldal;
        private HScrollBar Sb_Piros;
        private HScrollBar SB_Zold;
        private HScrollBar SB_Kek;
        private Panel Lb_Negyzet;
        private Label szoveg;
        private Label Lb_Oldal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}