namespace BookStore_Application
{
    partial class BookingListForBS
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
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooking.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBooking.Location = new System.Drawing.Point(0, 0);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(1);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 123;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1496, 848);
            this.dgvBooking.TabIndex = 4;
            this.dgvBooking.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBooking_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Booking ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Discount";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Final Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount Paid";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "AmountRemain";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Created";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Updated";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // BookingListForBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 848);
            this.Controls.Add(this.dgvBooking);
            this.Name = "BookingListForBS";
            this.Text = "BookingListForBS";
            this.Load += new System.EventHandler(this.BookingListForBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}