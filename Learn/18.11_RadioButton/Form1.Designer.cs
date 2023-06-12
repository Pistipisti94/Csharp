namespace _18._11_RadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rb_LNKO = new System.Windows.Forms.RadioButton();
            this.Rb_LKKT = new System.Windows.Forms.RadioButton();
            this.TBx_A = new System.Windows.Forms.TextBox();
            this.TBx_B = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "B:";
            // 
            // Rb_LNKO
            // 
            this.Rb_LNKO.AutoSize = true;
            this.Rb_LNKO.Location = new System.Drawing.Point(19, 18);
            this.Rb_LNKO.Name = "Rb_LNKO";
            this.Rb_LNKO.Size = new System.Drawing.Size(55, 19);
            this.Rb_LNKO.TabIndex = 1;
            this.Rb_LNKO.TabStop = true;
            this.Rb_LNKO.Text = "LNKO";
            this.Rb_LNKO.UseVisualStyleBackColor = true;
            // 
            // Rb_LKKT
            // 
            this.Rb_LKKT.AutoSize = true;
            this.Rb_LKKT.Location = new System.Drawing.Point(19, 57);
            this.Rb_LKKT.Name = "Rb_LKKT";
            this.Rb_LKKT.Size = new System.Drawing.Size(51, 19);
            this.Rb_LKKT.TabIndex = 2;
            this.Rb_LKKT.TabStop = true;
            this.Rb_LKKT.Text = "LKKT";
            this.Rb_LKKT.UseVisualStyleBackColor = true;
            // 
            // TBx_A
            // 
            this.TBx_A.Location = new System.Drawing.Point(78, 62);
            this.TBx_A.Name = "TBx_A";
            this.TBx_A.Size = new System.Drawing.Size(100, 23);
            this.TBx_A.TabIndex = 3;
            // 
            // TBx_B
            // 
            this.TBx_B.Location = new System.Drawing.Point(78, 110);
            this.TBx_B.Name = "TBx_B";
            this.TBx_B.Size = new System.Drawing.Size(100, 23);
            this.TBx_B.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Rb_LNKO);
            this.panel1.Controls.Add(this.Rb_LKKT);
            this.panel1.Location = new System.Drawing.Point(228, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feladatválasztás";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ellenőrzés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(335, 172);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Kilépés";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 215);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBx_B);
            this.Controls.Add(this.TBx_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RadioButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton Rb_LNKO;
        private RadioButton Rb_LKKT;
        private TextBox TBx_A;
        private TextBox TBx_B;
        private Panel panel1;
        private Label label3;
        private Button button1;
        private Button close;
    }
}