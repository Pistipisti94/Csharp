namespace _18._3_eger
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
            this.PanelIgazit = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelIgazit
            // 
            this.PanelIgazit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelIgazit.AutoSize = true;
            this.PanelIgazit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelIgazit.Location = new System.Drawing.Point(283, 38);
            this.PanelIgazit.Name = "PanelIgazit";
            this.PanelIgazit.Size = new System.Drawing.Size(200, 100);
            this.PanelIgazit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelIgazit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelIgazit;
    }
}