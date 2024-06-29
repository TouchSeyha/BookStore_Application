using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookStore_Application
{
    public partial class frmBookSystembtn : Form
    {
        public frmBookSystembtn()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public List<ClsTempSale> tempSaleList = new List<ClsTempSale>();
        private void frmBookSystembtn_Load(object sender, EventArgs e)
        {
            MainClear();
        }

        private void Clear()
        {
            txtInvoice.Text = (GetLatestInvoiceId() + 1).ToString();
            cmbCustomer.Text = "";
            cmbEmployee.Text = "";
            txtBookTitle.Text = "";
            txtSellingprice.Text = "";
            txtQuantity.Text = "";
            txtTotalPrice.Text = "";
            lblStock.Text = "";

            foreach (Customer emp in db.Customers)
            {
                cmbCustomer.Items.Add(emp.CustomerName);
            }
            foreach (Employee emp in db.Employees)
            {
                cmbEmployee.Items.Add(emp.EmployeeName);
            }

            cmbEmployee.Text = AppManager.GetInstance().loginEmployee.EmployeeName;
        }

        public void MainClear()
        {
            cmbCustomer.Text = "";
            Clear();
            dgvSale.Rows.Clear();
            tempSaleList.Clear();
            txtDiscount.Text = "";

            txtboxFinalTotalPrice.Text = 0m.ToString("F2");
            txtboxAmountPaid.Text = 0m.ToString("F2");
            txtboxAmountRemain.Text = 0m.ToString("F2");
        }

        private int GetLatestInvoiceId()
        {
            var booking = db.Sales
                .OrderByDescending(c => c.SaleId)
                .FirstOrDefault();
            if (booking != null)
                return booking.SaleId;
            return 0;
        }

        public void LoadDataToForm(int bookingId)
        {
            var booking = db.Books
                            .Where(c => c.BookId == bookingId)
                            .FirstOrDefault();
            if (booking != null)
            {
                txtBookTitle.Text = booking.Title.ToString();
                txtSellingprice.Text = booking.SellingPrice.ToString();
                txtQuantity.Text = "1";


                Stock stock = db.Stocks
                            .Where(s => s.StockId == bookingId).FirstOrDefault();
                if (stock != null)
                {
                    lblStock.Text = stock.Quantity.ToString();
                }

                CalculateTotalPrice();

            }
        }

        private void CalculateTotalPrice()
        {
            if (!string.IsNullOrEmpty(txtSellingprice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                decimal sellingPrice = decimal.Parse(txtSellingprice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                decimal totalPrice = sellingPrice * quantity;


                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBookTitle.Text) &&
                !string.IsNullOrEmpty(txtQuantity.Text))
            {
                string productName = txtBookTitle.Text;
                Book product = db.Books
                                    .Where(p => p.Title == productName)
                                    .FirstOrDefault();

                if (product != null)
                {
                    int productId = product.BookId;
                    Stock stock = db.Stocks
                                    .Where(s => s.BookId == productId)
                                    .FirstOrDefault();

                    int quantity = int.Parse(txtQuantity.Text);
                    if (quantity > stock.Quantity)
                    {
                        txtQuantity.Text = "0";
                        MessageBox.Show("Quantity Over Current Stocks.");
                        return;
                    }
                }
            }
            CalculateTotalPrice();
        }

        private void DeleteBooking(int bookingId)
        {
            var booking = db.Bookings
                            .Where(b => b.BookingId == bookingId)
                            .FirstOrDefault();

            if (booking != null)
            {
                var bookingDetails = db.BookingDetails
                                    .Where(bd => bd.BookingId == bookingId)
                                    .ToList();

                db.BookingDetails.RemoveRange(bookingDetails);
                db.Bookings.Remove(booking);
                db.SaveChanges();

                MessageBox.Show("Booking deleted successfully.");
            }
        }

        private void btnShowBookId_Click(object sender, EventArgs e)
        {
            BookListDataforSale purchaseList = new BookListDataforSale();

            purchaseList.bookSystembtn = this;
            purchaseList.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookTitle.Text))
            {
                MessageBox.Show("Please Select a Book!");
                return;
            }

            if (!string.IsNullOrEmpty(txtSellingprice.Text) &&
                !string.IsNullOrEmpty(txtQuantity.Text))
            {
                string productName = txtBookTitle.Text;
                decimal sellingPrice = decimal.Parse(txtSellingprice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                decimal totalPrice = sellingPrice * quantity;

                decimal discountPercentage = GetDiscountOrDefault(txtDiscount.Text);
                decimal discount = (totalPrice * discountPercentage) / 100; ;
                decimal finalPrice = totalPrice - discount;


                ClsTempSale product = new ClsTempSale(productName, sellingPrice, quantity, totalPrice, discountPercentage, discount, finalPrice);
                tempSaleList.Add(product);

                BindProductList();
                Clear();

                txtboxFinalTotalPrice.Text = GetFinalAmount().ToString();


                // Calculate remaining amount
                decimal finalTotalPrice = decimal.Parse(txtboxFinalTotalPrice.Text);
                decimal amountRemain = finalTotalPrice - 0;
                txtboxAmountRemain.Text = amountRemain.ToString();
            }
        }

        private decimal GetDiscountOrDefault(string discountText)
        {
            if (decimal.TryParse(discountText, out decimal discount))
            {
                return discount;
            }
            return 0; // Return 0 if the discount is not provided or invalid
        }

        // Need to modify to delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSale.SelectedRows.Count > 0)
            {
                string productName = dgvSale.SelectedRows[0].Cells[1].Value.ToString();
                for (int i = 0; i < tempSaleList.Count; i++)
                {
                    ClsTempSale tempProduct = tempSaleList[i];
                    if (tempProduct.Name == productName)
                    {
                        tempSaleList.Remove(tempProduct);
                    }
                }
                BindProductList();
            }
            else
            {
                MessageBox.Show("Please Select any Record!");
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmSaleList purchaseList = new frmSaleList();

            purchaseList.saleEntry = this;
            purchaseList.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customerName = cmbCustomer.Text;
            string employeeName = cmbEmployee.Text;

            if (string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(employeeName) ||
                dgvSale.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Customer and Employee!");
                return;
            }

            Sale sale = new Sale()
            {
                SaleId = GetLatestInvoiceId() + 1,
                Employee = db.Employees
                    .Where(emp => emp.EmployeeName == employeeName)
                    .FirstOrDefault(),
                Customer = db.Customers
                    .Where(cus => cus.CustomerName == customerName)
                    .FirstOrDefault(),
                TotalAmount = GetTotalAmount(),
                TotalDiscount = GetDiscountOrDefault(txtDiscount.Text),
                FinalAmount = decimal.Parse(txtboxFinalTotalPrice.Text),
                AmountPaid = decimal.Parse(txtboxAmountPaid.Text), 
                AmountRemain = decimal.Parse(txtboxAmountRemain.Text), 
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            db.Sales.Add(sale);
            db.SaveChanges();

            //Save to  SaleDetail

            foreach (ClsTempSale product in tempSaleList)
            {
                SaleDetail sd = new SaleDetail();

                sd.Sale = sale;
                sd.Book = db.Books
                                .Where(p => p.Title == product.Name)
                                .FirstOrDefault();
                sd.Quantity = product.Quantity;
                sd.SellingPrice = product.SellingPrice;
                sd.TotalPrice = product.TotalPrice;
                sd.DiscountPercentage = product.DiscountPercentage;
                sd.Discount = product.Discount;
                sd.FinalPrice = product.FinalPrice;
                sd.Created = DateTime.Now;
                sd.Updated = DateTime.Now;

                int productId = sd.Book.BookId;

                Stock stock = db.Stocks
                                .Where(s => s.BookId == productId)
                                .FirstOrDefault();

                if (stock != null)
                {
                    stock.Quantity -= product.Quantity;
                }

                db.SaleDetails.Add(sd);
                db.SaveChanges();
            }

            // When clicking on save to sale detail, booking should be deleted from db.Booking & db.BookingDetail
            int bookingId;
            if (int.TryParse(txtInvoice.Text, out bookingId))
            {
                DeleteBooking(bookingId);
            }


            MainClear();
            MessageBox.Show("Sale Complete!");
        }

        private void BindProductList()
        {
            dgvSale.Rows.Clear();
            int rowCount = 1;
            foreach (ClsTempSale product in tempSaleList)
            {
                dgvSale.Rows.Add(rowCount,
                    product.Name,
                    product.SellingPrice,
                    product.Quantity,
                    product.TotalPrice,
                    product.DiscountPercentage,
                    product.Discount,
                    product.FinalPrice
                    );
                rowCount++;
            }
        }

        private decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ClsTempSale p in tempSaleList)
            {
                totalAmount += p.TotalPrice;
            }
            return totalAmount;
        }

        private decimal GetFinalAmount()
        {
            decimal finalAmount = 0;

            foreach (ClsTempSale p in tempSaleList)
            {
                finalAmount += p.FinalPrice;
            }
            return finalAmount;
        }


        public void LoadDataFromInvoice(int invoiceId) // load to gridview for Sale List
        {
            MainClear();
            Sale sale = db.Sales
                                .Where(s => s.SaleId == invoiceId).FirstOrDefault();
            if (sale != null)
            {
                txtInvoice.Text = invoiceId.ToString();
                cmbCustomer.Text = sale.Customer.CustomerName;
                cmbEmployee.Text = sale.Employee.EmployeeName;
                txtboxFinalTotalPrice.Text = sale.FinalAmount.ToString();
                txtboxAmountPaid.Text = sale.AmountPaid.ToString();
                txtboxAmountRemain.Text = sale.AmountRemain.ToString();

                // add data to gridview

                var saleDetails = db.SaleDetails
                                .Where(sd => sd.SaleId == invoiceId);
                foreach (SaleDetail saleDetail in saleDetails)
                {
                    ClsTempSale tempProduct = new ClsTempSale();

                    tempProduct.Name = saleDetail.Book.Title;
                    tempProduct.Quantity = saleDetail.Quantity;
                    tempProduct.SellingPrice = saleDetail.SellingPrice;
                    tempProduct.TotalPrice = saleDetail.TotalPrice;
                    tempProduct.DiscountPercentage = saleDetail.DiscountPercentage;
                    tempProduct.Discount = saleDetail.Discount;
                    tempProduct.FinalPrice = saleDetail.FinalPrice;

                    tempSaleList.Add(tempProduct);
                }

                BindProductList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClearNew_Click(object sender, EventArgs e)
        {
            MainClear();
        }

        private void txtboxAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxAmountPaid.Text) ||
                string.IsNullOrEmpty(txtboxFinalTotalPrice.Text))
            {
                return;
            }

            double finalTotalPrice = Convert.ToDouble(txtboxFinalTotalPrice.Text);
            double totalAmountPay = Convert.ToDouble(txtboxAmountPaid.Text);
            double amountRemain = finalTotalPrice - totalAmountPay;

            txtboxAmountRemain.Text = amountRemain.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingListForBS bookingList = new BookingListForBS();
            bookingList.bookSystembtn = this;
            bookingList.Show();
        }

        public void LoadDataFromBooking(int invoiceId)
        {
            MainClear();

            Booking booking = db.Bookings
                        .Where(s => s.BookingId == invoiceId)
                        .FirstOrDefault();
            if (booking != null)
            {
                txtInvoice.Text = booking.BookingId.ToString(); // Ensure this sets the booking ID correctly
                cmbCustomer.Text = booking.Customer.CustomerName;
                cmbEmployee.Text = booking.Employee.EmployeeName;
                txtboxFinalTotalPrice.Text = booking.FinalAmount.ToString();
                txtboxAmountPaid.Text = booking.AmountPaid.ToString();
                txtboxAmountRemain.Text = booking.AmountRemain.ToString();


                //add data to gridview
                var bookingDetails = db.BookingDetails
                                    .Where(sd => sd.BookingId == invoiceId);
                foreach (BookingDetail bd in bookingDetails)
                {
                    ClsTempSale tempProduct = new ClsTempSale
                    {
                        Name = bd.Book.Title,
                        Quantity = bd.Quantity,
                        SellingPrice = bd.Book.SellingPrice,
                        TotalPrice = bd.TotalPrice,
                        DiscountPercentage = bd.DiscountPercentage,
                        Discount = bd.Discount,
                        FinalPrice = bd.FinalPrice
                    };

                    tempSaleList.Add(tempProduct);
                }

                BindProductList();
            }
        }

        // When Employee Click on the txtBoxAmountPaid it will be ready for input
        private void txtboxAmountPaid_Click(object sender, EventArgs e)
        {
            txtboxAmountPaid.Text= "";
        }
    }
}
