namespace _18._7_komponensek
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.atlag = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.max);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.atlag);
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 100);
            this.panel1.TabIndex = 0;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(509, 68);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(13, 15);
            this.max.TabIndex = 2;
            this.max.Text = "0";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(351, 68);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(13, 15);
            this.min.TabIndex = 2;
            this.min.Text = "0";
            // 
            // atlag
            // 
            this.atlag.AutoSize = true;
            this.atlag.Location = new System.Drawing.Point(219, 68);
            this.atlag.Name = "atlag";
            this.atlag.Size = new System.Drawing.Size(13, 15);
            this.atlag.TabIndex = 2;
            this.atlag.Text = "0";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(103, 69);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(13, 15);
            this.sum.TabIndex = 1;
            this.sum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Összeg:          ,átlag:          ,minimum:          ,maximum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label max;
        private Label min;
        private Label atlag;
        private Label sum;
        private Label label1;
    }
}