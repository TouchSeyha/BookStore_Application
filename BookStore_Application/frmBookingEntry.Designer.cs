namespace BookStore_Application
{
    partial class frmBookingEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxFinalTotalPrice = new System.Windows.Forms.TextBox();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnShowBookId = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSellingprice = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxAmountRemain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxAmountPaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(761, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 88;
            this.label1.Text = "Total Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxFinalTotalPrice
            // 
            this.txtboxFinalTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtboxFinalTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFinalTotalPrice.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtboxFinalTotalPrice.Location = new System.Drawing.Point(710, 154);
            this.txtboxFinalTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxFinalTotalPrice.Name = "txtboxFinalTotalPrice";
            this.txtboxFinalTotalPrice.ReadOnly = true;
            this.txtboxFinalTotalPrice.Size = new System.Drawing.Size(366, 38);
            this.txtboxFinalTotalPrice.TabIndex = 87;
            this.txtboxFinalTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.dgvBooking.ColumnHeadersHeight = 40;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBooking.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvBooking.Location = new System.Drawing.Point(0, 385);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(1);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 123;
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(1443, 472);
            this.dgvBooking.TabIndex = 91;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Title";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Selling Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Discount Percentage";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.btnShowBookId);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtSellingprice);
            this.panel2.Controls.Add(this.txtBookTitle);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 290);
            this.panel2.TabIndex = 82;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(191, 216);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(250, 32);
            this.txtDiscount.TabIndex = 96;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 95;
            this.label2.Text = "Discount % :";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(445, 78);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 29);
            this.lblStock.TabIndex = 92;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowBookId
            // 
            this.btnShowBookId.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookId.Location = new System.Drawing.Point(457, 43);
            this.btnShowBookId.Name = "btnShowBookId";
            this.btnShowBookId.Size = new System.Drawing.Size(43, 31);
            this.btnShowBookId.TabIndex = 91;
            this.btnShowBookId.Text = "...";
            this.btnShowBookId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowBookId.UseVisualStyleBackColor = true;
            this.btnShowBookId.Click += new System.EventHandler(this.btnShowBookId_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(191, 169);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(250, 32);
            this.txtTotalPrice.TabIndex = 90;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(191, 128);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 32);
            this.txtQuantity.TabIndex = 89;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtSellingprice
            // 
            this.txtSellingprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingprice.Location = new System.Drawing.Point(191, 82);
            this.txtSellingprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellingprice.Name = "txtSellingprice";
            this.txtSellingprice.Size = new System.Drawing.Size(250, 32);
            this.txtSellingprice.TabIndex = 88;
            this.txtSellingprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(191, 41);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(250, 32);
            this.txtBookTitle.TabIndex = 87;
            this.txtBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Location = new System.Drawing.Point(531, 194);
            this.btnNew.Margin = new System.Windows.Forms.Padding(1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(146, 56);
            this.btnNew.TabIndex = 67;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 75;
            this.label5.Text = "Book Title :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 80;
            this.label8.Text = "Total Price :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(531, 118);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 56);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 72;
            this.label7.Text = "Sell Price :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 74;
            this.label6.Text = "Quantity :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(531, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 56);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbEmployee);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.txtInvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 89);
            this.panel1.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(984, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 31);
            this.label13.TabIndex = 86;
            this.label13.Text = "Employee:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(472, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 31);
            this.label11.TabIndex = 85;
            this.label11.Text = "Customer:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(131, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 31);
            this.label12.TabIndex = 84;
            this.label12.Text = "Booking ID :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(1138, 30);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(297, 30);
            this.cmbEmployee.TabIndex = 14;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(626, 30);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(297, 30);
            this.cmbCustomer.TabIndex = 13;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.Location = new System.Drawing.Point(308, 31);
            this.txtInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvoice.Size = new System.Drawing.Size(67, 32);
            this.txtInvoice.TabIndex = 12;
            // 
            // btnGetData
            // 
            this.btnGetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGetData.Location = new System.Drawing.Point(30, 183);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(1);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(304, 55);
            this.btnGetData.TabIndex = 66;
            this.btnGetData.Text = "GET DATA";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(30, 116);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(304, 55);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearNew
            // 
            this.btnClearNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNew.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearNew.Location = new System.Drawing.Point(30, 44);
            this.btnClearNew.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearNew.Name = "btnClearNew";
            this.btnClearNew.Size = new System.Drawing.Size(304, 55);
            this.btnClearNew.TabIndex = 67;
            this.btnClearNew.Text = "NEW";
            this.btnClearNew.UseVisualStyleBackColor = false;
            this.btnClearNew.Click += new System.EventHandler(this.btnClearNew_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnClearNew);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnGetData);
            this.panel4.Location = new System.Drawing.Point(1088, 93);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 289);
            this.panel4.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(714, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(358, 42);
            this.label9.TabIndex = 95;
            this.label9.Text = "Amount remain";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxAmountRemain
            // 
            this.txtboxAmountRemain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtboxAmountRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAmountRemain.ForeColor = System.Drawing.Color.Orange;
            this.txtboxAmountRemain.Location = new System.Drawing.Point(710, 338);
            this.txtboxAmountRemain.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxAmountRemain.Name = "txtboxAmountRemain";
            this.txtboxAmountRemain.ReadOnly = true;
            this.txtboxAmountRemain.Size = new System.Drawing.Size(366, 38);
            this.txtboxAmountRemain.TabIndex = 94;
            this.txtboxAmountRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(744, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 42);
            this.label4.TabIndex = 93;
            this.label4.Text = "Amount Paid";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxAmountPaid
            // 
            this.txtboxAmountPaid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtboxAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAmountPaid.ForeColor = System.Drawing.Color.Yellow;
            this.txtboxAmountPaid.Location = new System.Drawing.Point(710, 246);
            this.txtboxAmountPaid.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxAmountPaid.Name = "txtboxAmountPaid";
            this.txtboxAmountPaid.Size = new System.Drawing.Size(366, 38);
            this.txtboxAmountPaid.TabIndex = 92;
            this.txtboxAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxAmountPaid.Click += new System.EventHandler(this.txtboxAmountPaid_Click);
            this.txtboxAmountPaid.TextChanged += new System.EventHandler(this.txtboxAmountPaid_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 89);
            this.label3.TabIndex = 87;
            this.label3.Text = "Booking Entry";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBookingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxAmountRemain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxAmountPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.txtboxFinalTotalPrice);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmBookingEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookingEntry";
            this.Load += new System.EventHandler(this.frmBookingEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSellingprice;
        private System.Windows.Forms.Button btnShowBookId;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxFinalTotalPrice;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxAmountRemain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxAmountPaid;
        private System.Windows.Forms.Label label3;
    }
}