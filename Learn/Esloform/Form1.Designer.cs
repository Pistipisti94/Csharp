namespace Esloform
{
    partial class Pikachu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pikachu));
            this.label1 = new System.Windows.Forms.Label();
            this.kilepes = new System.Windows.Forms.Button();
            this.szoroz = new System.Windows.Forms.Button();
            this.szorozosszeg = new System.Windows.Forms.NumericUpDown();
            this.osztoosszeg = new System.Windows.Forms.NumericUpDown();
            this.szorozszoveg = new System.Windows.Forms.Label();
            this.osztoszoveg = new System.Windows.Forms.Label();
            this.eredmeny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.szorozosszeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztoosszeg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIKACHU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kilepes
            // 
            this.kilepes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kilepes.ForeColor = System.Drawing.Color.Black;
            this.kilepes.Location = new System.Drawing.Point(902, 479);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(91, 30);
            this.kilepes.TabIndex = 1;
            this.kilepes.Text = "Kilép";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // szoroz
            // 
            this.szoroz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szoroz.ForeColor = System.Drawing.Color.Black;
            this.szoroz.Location = new System.Drawing.Point(120, 208);
            this.szoroz.Name = "szoroz";
            this.szoroz.Size = new System.Drawing.Size(75, 23);
            this.szoroz.TabIndex = 2;
            this.szoroz.Text = "Számolj";
            this.szoroz.UseVisualStyleBackColor = true;
            this.szoroz.Click += new System.EventHandler(this.szoroz_Click);
            // 
            // szorozosszeg
            // 
            this.szorozosszeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szorozosszeg.Location = new System.Drawing.Point(104, 114);
            this.szorozosszeg.Name = "szorozosszeg";
            this.szorozosszeg.Size = new System.Drawing.Size(120, 23);
            this.szorozosszeg.TabIndex = 3;
            // 
            // osztoosszeg
            // 
            this.osztoosszeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.osztoosszeg.Location = new System.Drawing.Point(104, 155);
            this.osztoosszeg.Name = "osztoosszeg";
            this.osztoosszeg.Size = new System.Drawing.Size(120, 23);
            this.osztoosszeg.TabIndex = 4;
            // 
            // szorozszoveg
            // 
            this.szorozszoveg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szorozszoveg.AutoSize = true;
            this.szorozszoveg.Location = new System.Drawing.Point(47, 116);
            this.szorozszoveg.Name = "szorozszoveg";
            this.szorozszoveg.Size = new System.Drawing.Size(44, 15);
            this.szorozszoveg.TabIndex = 5;
            this.szorozszoveg.Text = "Szorzó:";
            // 
            // osztoszoveg
            // 
            this.osztoszoveg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.osztoszoveg.AutoSize = true;
            this.osztoszoveg.Location = new System.Drawing.Point(51, 157);
            this.osztoszoveg.Name = "osztoszoveg";
            this.osztoszoveg.Size = new System.Drawing.Size(40, 15);
            this.osztoszoveg.TabIndex = 6;
            this.osztoszoveg.Text = "Osztó:";
            // 
            // eredmeny
            // 
            this.eredmeny.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eredmeny.AutoSize = true;
            this.eredmeny.BackColor = System.Drawing.SystemColors.Control;
            this.eredmeny.ForeColor = System.Drawing.Color.Black;
            this.eredmeny.Location = new System.Drawing.Point(138, 258);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(10, 15);
            this.eredmeny.TabIndex = 7;
            this.eredmeny.Text = " ";
            // 
            // Pikachu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::Esloform.Properties.Resources.pikachu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1005, 521);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.osztoszoveg);
            this.Controls.Add(this.szorozszoveg);
            this.Controls.Add(this.osztoosszeg);
            this.Controls.Add(this.szorozosszeg);
            this.Controls.Add(this.szoroz);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pikachu";
            this.Text = "Pikachu";
            this.Load += new System.EventHandler(this.Pikachu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.szorozosszeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztoosszeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button kilepes;
        private Button szoroz;
        private NumericUpDown szorozosszeg;
        private NumericUpDown osztoosszeg;
        private Label szorozszoveg;
        private Label osztoszoveg;
        private Label eredmeny;
    }
}