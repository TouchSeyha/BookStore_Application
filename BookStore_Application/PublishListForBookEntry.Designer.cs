namespace BookStore_Application
{
    partial class PublishListForBookEntry
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
            this.dgvPublish = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublish
            // 
            this.dgvPublish.AllowUserToAddRows = false;
            this.dgvPublish.AllowUserToDeleteRows = false;
            this.dgvPublish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublish.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvPublish.ColumnHeadersHeight = 30;
            this.dgvPublish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPublish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column10,
            this.Column11});
            this.dgvPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPublish.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvPublish.Location = new System.Drawing.Point(0, 0);
            this.dgvPublish.Margin = new System.Windows.Forms.Padding(1);
            this.dgvPublish.Name = "dgvPublish";
            this.dgvPublish.ReadOnly = true;
            this.dgvPublish.RowHeadersWidth = 123;
            this.dgvPublish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublish.Size = new System.Drawing.Size(1135, 761);
            this.dgvPublish.TabIndex = 5;
            this.dgvPublish.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPublish_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PublishHouse ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PublishHouse Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // PublishListForBookEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 761);
            this.Controls.Add(this.dgvPublish);
            this.Name = "PublishListForBookEntry";
            this.Text = "PublishListForBookEntry";
            this.Load += new System.EventHandler(this.PublishListForBookEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}