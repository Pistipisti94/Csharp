namespace _18._1_ugrik
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
            this.btnbalfel = new System.Windows.Forms.Button();
            this.btnballe = new System.Windows.Forms.Button();
            this.btnjobbfel = new System.Windows.Forms.Button();
            this.btnjobble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbalfel
            // 
            this.btnbalfel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbalfel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbalfel.Location = new System.Drawing.Point(114, 48);
            this.btnbalfel.Name = "btnbalfel";
            this.btnbalfel.Size = new System.Drawing.Size(75, 23);
            this.btnbalfel.TabIndex = 0;
            this.btnbalfel.Text = "balra fel";
            this.btnbalfel.UseVisualStyleBackColor = false;
            this.btnbalfel.Click += new System.EventHandler(this.btnbalfel_Click);
            // 
            // btnballe
            // 
            this.btnballe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnballe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnballe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnballe.Location = new System.Drawing.Point(114, 345);
            this.btnballe.Name = "btnballe";
            this.btnballe.Size = new System.Drawing.Size(75, 23);
            this.btnballe.TabIndex = 1;
            this.btnballe.Text = "balra le";
            this.btnballe.UseVisualStyleBackColor = false;
            this.btnballe.Click += new System.EventHandler(this.btnballe_Click);
            // 
            // btnjobbfel
            // 
            this.btnjobbfel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnjobbfel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnjobbfel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnjobbfel.Location = new System.Drawing.Point(639, 48);
            this.btnjobbfel.Name = "btnjobbfel";
            this.btnjobbfel.Size = new System.Drawing.Size(75, 23);
            this.btnjobbfel.TabIndex = 2;
            this.btnjobbfel.Text = "jobbra fel";
            this.btnjobbfel.UseVisualStyleBackColor = false;
            this.btnjobbfel.Click += new System.EventHandler(this.btnjobbfel_Click);
            // 
            // btnjobble
            // 
            this.btnjobble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnjobble.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnjobble.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnjobble.Location = new System.Drawing.Point(639, 345);
            this.btnjobble.Name = "btnjobble";
            this.btnjobble.Size = new System.Drawing.Size(75, 23);
            this.btnjobble.TabIndex = 3;
            this.btnjobble.Text = "jobbra le";
            this.btnjobble.UseVisualStyleBackColor = false;
            this.btnjobble.Click += new System.EventHandler(this.btnjobble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjobble);
            this.Controls.Add(this.btnjobbfel);
            this.Controls.Add(this.btnballe);
            this.Controls.Add(this.btnbalfel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbalfel;
        private Button btnballe;
        private Button btnjobbfel;
        private Button btnjobble;
    }
}