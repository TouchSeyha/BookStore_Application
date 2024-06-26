namespace BookStore_Application
{
    partial class frmPurchaseList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column12,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column11});
            this.dgvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchase.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPurchase.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchase.Margin = new System.Windows.Forms.Padding(1);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersWidth = 123;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(1406, 760);
            this.dgvPurchase.TabIndex = 4;
            this.dgvPurchase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPurchase_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Purchase ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total Amount";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Amount Paid";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount Remian";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Discount";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Note";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Created";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Updated";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // frmPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 760);
            this.Controls.Add(this.dgvPurchase);
            this.Name = "frmPurchaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPurchaseList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}