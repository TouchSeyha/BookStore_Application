namespace BookStore_Application
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishingHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishingHouseEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishingHouseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.publishingHouseToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.allListsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(100, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1100, 85);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::BookStore_Application.Properties.Resources.icons8_menu_48;
            this.pictureBox2.Location = new System.Drawing.Point(24, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorEntryToolStripMenuItem,
            this.authorListToolStripMenuItem});
            this.authorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.authorToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_author_48;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(107, 81);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // authorEntryToolStripMenuItem
            // 
            this.authorEntryToolStripMenuItem.Name = "authorEntryToolStripMenuItem";
            this.authorEntryToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.authorEntryToolStripMenuItem.Text = "Author Entry";
            this.authorEntryToolStripMenuItem.Click += new System.EventHandler(this.authorEntryToolStripMenuItem_Click);
            // 
            // authorListToolStripMenuItem
            // 
            this.authorListToolStripMenuItem.Name = "authorListToolStripMenuItem";
            this.authorListToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.authorListToolStripMenuItem.Text = "Author List";
            this.authorListToolStripMenuItem.Click += new System.EventHandler(this.authorListToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEntryToolStripMenuItem,
            this.bookListToolStripMenuItem});
            this.bookToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bookToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_book_481;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(91, 81);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.bookListToolStripMenuItem.Text = "Book List";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreEntryToolStripMenuItem,
            this.genreListToolStripMenuItem});
            this.genreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.genreToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_comedy_48;
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(100, 81);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // genreEntryToolStripMenuItem
            // 
            this.genreEntryToolStripMenuItem.Name = "genreEntryToolStripMenuItem";
            this.genreEntryToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.genreEntryToolStripMenuItem.Text = "Genre Entry";
            this.genreEntryToolStripMenuItem.Click += new System.EventHandler(this.genreEntryToolStripMenuItem_Click);
            // 
            // genreListToolStripMenuItem
            // 
            this.genreListToolStripMenuItem.Name = "genreListToolStripMenuItem";
            this.genreListToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.genreListToolStripMenuItem.Text = "Genre List";
            this.genreListToolStripMenuItem.Click += new System.EventHandler(this.genreListToolStripMenuItem_Click);
            // 
            // publishingHouseToolStripMenuItem
            // 
            this.publishingHouseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.publishingHouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publishingHouseEntryToolStripMenuItem,
            this.publishingHouseListToolStripMenuItem});
            this.publishingHouseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.publishingHouseToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_news_48;
            this.publishingHouseToolStripMenuItem.Name = "publishingHouseToolStripMenuItem";
            this.publishingHouseToolStripMenuItem.Size = new System.Drawing.Size(207, 81);
            this.publishingHouseToolStripMenuItem.Text = "Publishing House";
            // 
            // publishingHouseEntryToolStripMenuItem
            // 
            this.publishingHouseEntryToolStripMenuItem.Name = "publishingHouseEntryToolStripMenuItem";
            this.publishingHouseEntryToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.publishingHouseEntryToolStripMenuItem.Text = "Publishing House Entry";
            this.publishingHouseEntryToolStripMenuItem.Click += new System.EventHandler(this.publishingHouseEntryToolStripMenuItem_Click);
            // 
            // publishingHouseListToolStripMenuItem
            // 
            this.publishingHouseListToolStripMenuItem.Name = "publishingHouseListToolStripMenuItem";
            this.publishingHouseListToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.publishingHouseListToolStripMenuItem.Text = "Publishing House List";
            this.publishingHouseListToolStripMenuItem.Click += new System.EventHandler(this.publishingHouseListToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierEntryToolStripMenuItem,
            this.supplierListToolStripMenuItem});
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.supplierToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_hangar_48;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(121, 81);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // supplierEntryToolStripMenuItem
            // 
            this.supplierEntryToolStripMenuItem.Name = "supplierEntryToolStripMenuItem";
            this.supplierEntryToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.supplierEntryToolStripMenuItem.Text = "Supplier Entry";
            this.supplierEntryToolStripMenuItem.Click += new System.EventHandler(this.supplierEntryToolStripMenuItem_Click);
            // 
            // supplierListToolStripMenuItem
            // 
            this.supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            this.supplierListToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.supplierListToolStripMenuItem.Text = "Supplier List";
            this.supplierListToolStripMenuItem.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // allListsToolStripMenuItem
            // 
            this.allListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockListsToolStripMenuItem,
            this.bookingListsToolStripMenuItem,
            this.purchaseListsToolStripMenuItem,
            this.saleListsToolStripMenuItem});
            this.allListsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.allListsToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_news_48;
            this.allListsToolStripMenuItem.Name = "allListsToolStripMenuItem";
            this.allListsToolStripMenuItem.Size = new System.Drawing.Size(111, 81);
            this.allListsToolStripMenuItem.Text = "All Lists";
            // 
            // stockListsToolStripMenuItem
            // 
            this.stockListsToolStripMenuItem.Name = "stockListsToolStripMenuItem";
            this.stockListsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.stockListsToolStripMenuItem.Text = "Stock Lists";
            this.stockListsToolStripMenuItem.Click += new System.EventHandler(this.stockListsToolStripMenuItem_Click);
            // 
            // bookingListsToolStripMenuItem
            // 
            this.bookingListsToolStripMenuItem.Name = "bookingListsToolStripMenuItem";
            this.bookingListsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.bookingListsToolStripMenuItem.Text = "Booking Lists";
            this.bookingListsToolStripMenuItem.Click += new System.EventHandler(this.bookingListsToolStripMenuItem_Click);
            // 
            // purchaseListsToolStripMenuItem
            // 
            this.purchaseListsToolStripMenuItem.Name = "purchaseListsToolStripMenuItem";
            this.purchaseListsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.purchaseListsToolStripMenuItem.Text = "Purchase Lists";
            this.purchaseListsToolStripMenuItem.Click += new System.EventHandler(this.purchaseListsToolStripMenuItem_Click);
            // 
            // saleListsToolStripMenuItem
            // 
            this.saleListsToolStripMenuItem.Name = "saleListsToolStripMenuItem";
            this.saleListsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.saleListsToolStripMenuItem.Text = "Sale Lists";
            this.saleListsToolStripMenuItem.Click += new System.EventHandler(this.saleListsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingDetailsToolStripMenuItem1,
            this.purchaseDetailsToolStripMenuItem1,
            this.saleDetailsToolStripMenuItem1});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Image = global::BookStore_Application.Properties.Resources.icons8_scroll_48;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(115, 81);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // bookingDetailsToolStripMenuItem1
            // 
            this.bookingDetailsToolStripMenuItem1.Name = "bookingDetailsToolStripMenuItem1";
            this.bookingDetailsToolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.bookingDetailsToolStripMenuItem1.Text = "Booking Details";
            this.bookingDetailsToolStripMenuItem1.Click += new System.EventHandler(this.bookingDetailsToolStripMenuItem1_Click);
            // 
            // purchaseDetailsToolStripMenuItem1
            // 
            this.purchaseDetailsToolStripMenuItem1.Name = "purchaseDetailsToolStripMenuItem1";
            this.purchaseDetailsToolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.purchaseDetailsToolStripMenuItem1.Text = "Purchase Details";
            this.purchaseDetailsToolStripMenuItem1.Click += new System.EventHandler(this.purchaseDetailsToolStripMenuItem1_Click);
            // 
            // saleDetailsToolStripMenuItem1
            // 
            this.saleDetailsToolStripMenuItem1.Name = "saleDetailsToolStripMenuItem1";
            this.saleDetailsToolStripMenuItem1.Size = new System.Drawing.Size(242, 34);
            this.saleDetailsToolStripMenuItem1.Text = "Sale Details";
            this.saleDetailsToolStripMenuItem1.Click += new System.EventHandler(this.saleDetailsToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.pictureBox1.Image = global::BookStore_Application.Properties.Resources.icons8_menu_48;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::BookStore_Application.Properties.Resources.icons8_warehouse_96;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(727, 176);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(329, 146);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "                  STOCK";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::BookStore_Application.Properties.Resources.icons8_grocery_store_961;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(41, 176);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPurchase.Size = new System.Drawing.Size(329, 146);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.Text = "                PURCHASE";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            this.btnPurchase.MouseLeave += new System.EventHandler(this.btnPurchase_MouseLeave);
            this.btnPurchase.MouseHover += new System.EventHandler(this.btnPurchase_MouseHover);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Image = global::BookStore_Application.Properties.Resources.icons8_add_basket_96;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(384, 176);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBooking.Size = new System.Drawing.Size(329, 146);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "               BOOKING";
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            this.btnBooking.MouseLeave += new System.EventHandler(this.btnBooking_MouseLeave);
            this.btnBooking.MouseHover += new System.EventHandler(this.btnBooking_MouseHover);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnPos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Image = global::BookStore_Application.Properties.Resources.icons8_cash_register_96;
            this.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.Location = new System.Drawing.Point(384, 353);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPos.Size = new System.Drawing.Size(329, 146);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "               POS SYSTEM";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            this.btnPos.MouseLeave += new System.EventHandler(this.btnPos_MouseLeave);
            this.btnPos.MouseHover += new System.EventHandler(this.btnPos_MouseHover);
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(57)))), ((int)(((byte)(4)))));
            this.btnCloseMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCloseMain.Image = global::BookStore_Application.Properties.Resources.icons8_log_out_481;
            this.btnCloseMain.Location = new System.Drawing.Point(0, 634);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(82, 61);
            this.btnCloseMain.TabIndex = 3;
            this.btnCloseMain.UseVisualStyleBackColor = false;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 695);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnCloseMain);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1116, 696);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishingHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseMain;
        private System.Windows.Forms.ToolStripMenuItem authorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishingHouseEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishingHouseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierListToolStripMenuItem;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem allListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleListsToolStripMenuItem;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saleDetailsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}