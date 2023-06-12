namespace _18._10_Szorzotabla
{
    partial class Szorzotabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szorzotabla));
            this.lb_Joalasz = new System.Windows.Forms.Label();
            this.lb_Rosszvalasz = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Joalasz
            // 
            this.lb_Joalasz.AutoSize = true;
            this.lb_Joalasz.Location = new System.Drawing.Point(30, 372);
            this.lb_Joalasz.Name = "lb_Joalasz";
            this.lb_Joalasz.Size = new System.Drawing.Size(107, 15);
            this.lb_Joalasz.TabIndex = 0;
            this.lb_Joalasz.Text = "Jó válaszaid száma:";
            // 
            // lb_Rosszvalasz
            // 
            this.lb_Rosszvalasz.AutoSize = true;
            this.lb_Rosszvalasz.Location = new System.Drawing.Point(30, 396);
            this.lb_Rosszvalasz.Name = "lb_Rosszvalasz";
            this.lb_Rosszvalasz.Size = new System.Drawing.Size(125, 15);
            this.lb_Rosszvalasz.TabIndex = 0;
            this.lb_Rosszvalasz.Text = "Rossz válaszaid száma:";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(12, 424);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Kilépés";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(31, 29);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(572, 317);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_CellBeginEdit);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            // 
            // Szorzotabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lb_Rosszvalasz);
            this.Controls.Add(this.lb_Joalasz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Szorzotabla";
            this.Text = "Szorzótábla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Joalasz;
        private Label lb_Rosszvalasz;
        private Button close;
        private DataGridView dataGridView;
    }
}