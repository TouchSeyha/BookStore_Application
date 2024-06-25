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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToSystem = new System.Windows.Forms.Button();
            this.btnCloseMain = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.publishingHouseToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(117, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(613, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorEntryToolStripMenuItem,
            this.authorListToolStripMenuItem});
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(99, 64);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // authorEntryToolStripMenuItem
            // 
            this.authorEntryToolStripMenuItem.Name = "authorEntryToolStripMenuItem";
            this.authorEntryToolStripMenuItem.Size = new System.Drawing.Size(222, 36);
            this.authorEntryToolStripMenuItem.Text = "Author Entry";
            this.authorEntryToolStripMenuItem.Click += new System.EventHandler(this.authorEntryToolStripMenuItem_Click);
            // 
            // authorListToolStripMenuItem
            // 
            this.authorListToolStripMenuItem.Name = "authorListToolStripMenuItem";
            this.authorListToolStripMenuItem.Size = new System.Drawing.Size(222, 36);
            this.authorListToolStripMenuItem.Text = "Author List";
            this.authorListToolStripMenuItem.Click += new System.EventHandler(this.authorListToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookEntryToolStripMenuItem,
            this.bookListToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(80, 64);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // bookEntryToolStripMenuItem
            // 
            this.bookEntryToolStripMenuItem.Name = "bookEntryToolStripMenuItem";
            this.bookEntryToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.bookEntryToolStripMenuItem.Text = "Book Entry";
            this.bookEntryToolStripMenuItem.Click += new System.EventHandler(this.bookEntryToolStripMenuItem_Click);
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.bookListToolStripMenuItem.Text = "Book List";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreEntryToolStripMenuItem,
            this.genreListToolStripMenuItem});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(90, 64);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // genreEntryToolStripMenuItem
            // 
            this.genreEntryToolStripMenuItem.Name = "genreEntryToolStripMenuItem";
            this.genreEntryToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.genreEntryToolStripMenuItem.Text = "Genre Entry";
            this.genreEntryToolStripMenuItem.Click += new System.EventHandler(this.genreEntryToolStripMenuItem_Click);
            // 
            // genreListToolStripMenuItem
            // 
            this.genreListToolStripMenuItem.Name = "genreListToolStripMenuItem";
            this.genreListToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.genreListToolStripMenuItem.Text = "Genre List";
            this.genreListToolStripMenuItem.Click += new System.EventHandler(this.genreListToolStripMenuItem_Click);
            // 
            // publishingHouseToolStripMenuItem
            // 
            this.publishingHouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publishingHouseEntryToolStripMenuItem,
            this.publishingHouseListToolStripMenuItem});
            this.publishingHouseToolStripMenuItem.Name = "publishingHouseToolStripMenuItem";
            this.publishingHouseToolStripMenuItem.Size = new System.Drawing.Size(212, 64);
            this.publishingHouseToolStripMenuItem.Text = "Publishing House";
            // 
            // publishingHouseEntryToolStripMenuItem
            // 
            this.publishingHouseEntryToolStripMenuItem.Name = "publishingHouseEntryToolStripMenuItem";
            this.publishingHouseEntryToolStripMenuItem.Size = new System.Drawing.Size(335, 36);
            this.publishingHouseEntryToolStripMenuItem.Text = "Publishing House Entry";
            this.publishingHouseEntryToolStripMenuItem.Click += new System.EventHandler(this.publishingHouseEntryToolStripMenuItem_Click);
            // 
            // publishingHouseListToolStripMenuItem
            // 
            this.publishingHouseListToolStripMenuItem.Name = "publishingHouseListToolStripMenuItem";
            this.publishingHouseListToolStripMenuItem.Size = new System.Drawing.Size(335, 36);
            this.publishingHouseListToolStripMenuItem.Text = "Publishing House List";
            this.publishingHouseListToolStripMenuItem.Click += new System.EventHandler(this.publishingHouseListToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierEntryToolStripMenuItem,
            this.supplierListToolStripMenuItem});
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(114, 64);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // supplierEntryToolStripMenuItem
            // 
            this.supplierEntryToolStripMenuItem.Name = "supplierEntryToolStripMenuItem";
            this.supplierEntryToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.supplierEntryToolStripMenuItem.Text = "Supplier Entry";
            this.supplierEntryToolStripMenuItem.Click += new System.EventHandler(this.supplierEntryToolStripMenuItem_Click);
            // 
            // supplierListToolStripMenuItem
            // 
            this.supplierListToolStripMenuItem.Name = "supplierListToolStripMenuItem";
            this.supplierListToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.supplierListToolStripMenuItem.Text = "Supplier List";
            this.supplierListToolStripMenuItem.Click += new System.EventHandler(this.supplierListToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(1);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(117, 496);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockEntryToolStripMenuItem,
            this.stockListToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(83, 35);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockEntryToolStripMenuItem
            // 
            this.stockEntryToolStripMenuItem.Name = "stockEntryToolStripMenuItem";
            this.stockEntryToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.stockEntryToolStripMenuItem.Text = "Stock Entry";
            this.stockEntryToolStripMenuItem.Click += new System.EventHandler(this.stockEntryToolStripMenuItem_Click);
            // 
            // stockListToolStripMenuItem
            // 
            this.stockListToolStripMenuItem.Name = "stockListToolStripMenuItem";
            this.stockListToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.stockListToolStripMenuItem.Text = "Stock List";
            this.stockListToolStripMenuItem.Click += new System.EventHandler(this.stockListToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingEntryToolStripMenuItem,
            this.bookingListToolStripMenuItem});
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(113, 35);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingEntryToolStripMenuItem
            // 
            this.bookingEntryToolStripMenuItem.Name = "bookingEntryToolStripMenuItem";
            this.bookingEntryToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.bookingEntryToolStripMenuItem.Text = "Booking Entry";
            this.bookingEntryToolStripMenuItem.Click += new System.EventHandler(this.bookingEntryToolStripMenuItem_Click);
            // 
            // bookingListToolStripMenuItem
            // 
            this.bookingListToolStripMenuItem.Name = "bookingListToolStripMenuItem";
            this.bookingListToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.bookingListToolStripMenuItem.Text = "Booking List";
            this.bookingListToolStripMenuItem.Click += new System.EventHandler(this.bookingListToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseEntryToolStripMenuItem,
            this.purchaseListToolStripMenuItem});
            this.purchaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(119, 35);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // purchaseEntryToolStripMenuItem
            // 
            this.purchaseEntryToolStripMenuItem.Name = "purchaseEntryToolStripMenuItem";
            this.purchaseEntryToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.purchaseEntryToolStripMenuItem.Text = "Purchase Entry";
            this.purchaseEntryToolStripMenuItem.Click += new System.EventHandler(this.purchaseEntryToolStripMenuItem_Click);
            // 
            // purchaseListToolStripMenuItem
            // 
            this.purchaseListToolStripMenuItem.Name = "purchaseListToolStripMenuItem";
            this.purchaseListToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.purchaseListToolStripMenuItem.Text = "Purchase List";
            this.purchaseListToolStripMenuItem.Click += new System.EventHandler(this.purchaseListToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleEntryToolStripMenuItem,
            this.saleListToolStripMenuItem});
            this.saleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(69, 35);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // saleEntryToolStripMenuItem
            // 
            this.saleEntryToolStripMenuItem.Name = "saleEntryToolStripMenuItem";
            this.saleEntryToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.saleEntryToolStripMenuItem.Text = "Sale Entry";
            this.saleEntryToolStripMenuItem.Click += new System.EventHandler(this.saleEntryToolStripMenuItem_Click);
            // 
            // saleListToolStripMenuItem
            // 
            this.saleListToolStripMenuItem.Name = "saleListToolStripMenuItem";
            this.saleListToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.saleListToolStripMenuItem.Text = "Sale List";
            this.saleListToolStripMenuItem.Click += new System.EventHandler(this.saleListToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingDetailsToolStripMenuItem,
            this.purchaseDetailsToolStripMenuItem,
            this.saleDetailsToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(97, 35);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bookingDetailsToolStripMenuItem
            // 
            this.bookingDetailsToolStripMenuItem.Name = "bookingDetailsToolStripMenuItem";
            this.bookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.bookingDetailsToolStripMenuItem.Text = "Booking Details";
            this.bookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookingDetailsToolStripMenuItem_Click);
            // 
            // purchaseDetailsToolStripMenuItem
            // 
            this.purchaseDetailsToolStripMenuItem.Name = "purchaseDetailsToolStripMenuItem";
            this.purchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.purchaseDetailsToolStripMenuItem.Text = "Purchase Details";
            this.purchaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.purchaseDetailsToolStripMenuItem_Click);
            // 
            // saleDetailsToolStripMenuItem
            // 
            this.saleDetailsToolStripMenuItem.Name = "saleDetailsToolStripMenuItem";
            this.saleDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 36);
            this.saleDetailsToolStripMenuItem.Text = "Sale Details";
            this.saleDetailsToolStripMenuItem.Click += new System.EventHandler(this.saleDetailsToolStripMenuItem_Click);
            // 
            // btnToSystem
            // 
            this.btnToSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnToSystem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnToSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToSystem.Font = new System.Drawing.Font("Palatino Linotype", 28.75F, System.Drawing.FontStyle.Bold);
            this.btnToSystem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnToSystem.Location = new System.Drawing.Point(230, 169);
            this.btnToSystem.Name = "btnToSystem";
            this.btnToSystem.Size = new System.Drawing.Size(390, 175);
            this.btnToSystem.TabIndex = 2;
            this.btnToSystem.Text = "POS SYSTEM";
            this.btnToSystem.UseVisualStyleBackColor = false;
            this.btnToSystem.Click += new System.EventHandler(this.btnToSystem_Click);
            // 
            // btnCloseMain
            // 
            this.btnCloseMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseMain.BackColor = System.Drawing.Color.LightCoral;
            this.btnCloseMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCloseMain.Location = new System.Drawing.Point(0, 402);
            this.btnCloseMain.Name = "btnCloseMain";
            this.btnCloseMain.Size = new System.Drawing.Size(117, 48);
            this.btnCloseMain.TabIndex = 3;
            this.btnCloseMain.Text = "Close";
            this.btnCloseMain.UseVisualStyleBackColor = false;
            this.btnCloseMain.Click += new System.EventHandler(this.btnCloseMain_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(729, 496);
            this.Controls.Add(this.btnToSystem);
            this.Controls.Add(this.btnCloseMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishingHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnToSystem;
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
        private System.Windows.Forms.ToolStripMenuItem stockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleListToolStripMenuItem;
    }
}