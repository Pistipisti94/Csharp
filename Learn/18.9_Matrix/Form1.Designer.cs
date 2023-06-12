namespace _18._9_Matrix
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numS = new System.Windows.Forms.NumericUpDown();
            this.numO = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.richTextBox.Location = new System.Drawing.Point(614, 155);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(174, 283);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mehet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add meg a mátrix méretét:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oszlop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sor:";
            // 
            // numS
            // 
            this.numS.Location = new System.Drawing.Point(333, 46);
            this.numS.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numS.Name = "numS";
            this.numS.Size = new System.Drawing.Size(35, 23);
            this.numS.TabIndex = 5;
            this.numS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numO
            // 
            this.numO.Location = new System.Drawing.Point(455, 46);
            this.numO.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numO.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numO.Name = "numO";
            this.numO.Size = new System.Drawing.Size(35, 23);
            this.numO.TabIndex = 5;
            this.numO.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eredmény:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Location = new System.Drawing.Point(122, 155);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(480, 283);
            this.dataGridView.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numO);
            this.Controls.Add(this.numS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numS;
        private NumericUpDown numO;
        private Label label4;
        private DataGridView dataGridView;
    }
}