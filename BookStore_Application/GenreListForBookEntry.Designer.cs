namespace BookStore_Application
{
    partial class GenreListForBookEntry
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
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGenre
            // 
            this.dgvGenre.AllowUserToAddRows = false;
            this.dgvGenre.AllowUserToDeleteRows = false;
            this.dgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvGenre.ColumnHeadersHeight = 30;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column11});
            this.dgvGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dgvGenre.Location = new System.Drawing.Point(0, 0);
            this.dgvGenre.Margin = new System.Windows.Forms.Padding(1);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.ReadOnly = true;
            this.dgvGenre.RowHeadersWidth = 123;
            this.dgvGenre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenre.Size = new System.Drawing.Size(1135, 726);
            this.dgvGenre.TabIndex = 4;
            this.dgvGenre.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvGenre_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Genre ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genre Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // GenreListForBookEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 726);
            this.Controls.Add(this.dgvGenre);
            this.Name = "GenreListForBookEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenreListForBookEntry";
            this.Load += new System.EventHandler(this.GenreListForBookEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}