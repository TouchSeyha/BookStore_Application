using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_Application
{
    public partial class frmBookingEntry : Form
    {
        public frmBookingEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private List<ClsTempBooking> tempProductList = new List<ClsTempBooking>();

        private void frmBookingEntry_Load(object sender, EventArgs e)
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

            foreach (Customer c in db.Customers)
            {
                cmbCustomer.Items.Add(c.CustomerName);
            }
            foreach (Employee emp in db.Employees)
            {
                cmbEmployee.Items.Add(emp.EmployeeName);
            }

            cmbEmployee.Text = AppManager.GetInstance().loginEmployee.EmployeeName;
        }

        private void MainClear()
        {
            cmbCustomer.Text = "";
            Clear();
            dgvBooking.Rows.Clear();
            tempProductList.Clear();

            txtDiscount.Text = "";

            txtboxFinalTotalPrice.Text = 0m.ToString("F2");
            txtboxAmountPaid.Text = 0m.ToString("F2");
            txtboxAmountRemain.Text = 0m.ToString("F2");
        }

        private int GetLatestInvoiceId()
        {
            var booking = db.Bookings
                .OrderByDescending(c => c.BookingId)
                .FirstOrDefault();
            if (booking != null)
                return booking.BookingId;
            return 0;
        }

        // Load to txt box
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            MainClear();
        }

        private void BindProductList()
        {
            dgvBooking.Rows.Clear();
            int rowCount = 1;
            foreach (ClsTempBooking product in tempProductList)
            {
                dgvBooking.Rows.Add(rowCount,
                    product.Name,
                    product.SellingPrice,
                    product.Quantity,
                    product.TotalPrice,
                    product.DiscountPercentage,
                    product.Discount,
                    product.FinalPrice);
                rowCount++;
            }
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
                decimal discount = (totalPrice * discountPercentage) / 100; 
                decimal finalPrice = totalPrice - discount;


                ClsTempBooking product = new ClsTempBooking(productName, sellingPrice, quantity, totalPrice, discountPercentage, discount, finalPrice);
                tempProductList.Add(product);

                BindProductList();
                Clear();

                txtboxFinalTotalPrice.Text = GetFinalAmount().ToString();


                // Calculate remaining amount
                decimal finalTotalPrice = decimal.Parse(txtboxFinalTotalPrice.Text);
                decimal amountRemain = finalTotalPrice - 0;
                txtboxAmountRemain.Text = amountRemain.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {
                string productName = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                for (int i = 0; i < tempProductList.Count; i++)
                {
                    ClsTempBooking tempProduct = tempProductList[i];
                    if (tempProduct.Name == productName)
                    {
                        tempProductList.Remove(tempProduct);
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
            frmBookingList frmBookingList = new frmBookingList();

            frmBookingList.bookingEntry = this;
            frmBookingList.Show();
        }

        private void btnShowBookId_Click(object sender, EventArgs e)
        {
            BookFormForBooking bookList = new BookFormForBooking();

            bookList.bookingEntry = this;
            bookList.ShowDialog();
        }

        private void btnClearNew_Click(object sender, EventArgs e)
        {
            MainClear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customerName = cmbCustomer.Text;
            string employeeName = cmbEmployee.Text;
            string amountPaid = txtboxAmountPaid.Text;

            if (string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(employeeName) ||
                dgvBooking.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Customer and Employee!");
                return;
            }

            if(string.IsNullOrEmpty(amountPaid))
            {
                MessageBox.Show("Please Input Amount Paid!");
                return;
            }

            Booking sale = new Booking() {

                BookingId = GetLatestInvoiceId() + 1,
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

            db.Bookings.Add(sale);
            db.SaveChanges();

            //Save to BookingDetail Booking

            foreach (ClsTempBooking product in tempProductList)
            {
                BookingDetail sd = new BookingDetail();

                sd.Booking = sale;
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

                db.BookingDetails.Add(sd);
                db.SaveChanges();
            }
            MainClear();
            MessageBox.Show("Add Complete!");
        }

        private decimal GetDiscountOrDefault(string discountText)
        {
            if (decimal.TryParse(discountText, out decimal discount))
            {
                return discount;
            }
            return 0; // Return 0 if the discount is not provided or invalid
        }

        private decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ClsTempBooking p in tempProductList)
            {
                totalAmount += p.TotalPrice;
            }
            return totalAmount;
        }

        private decimal GetFinalAmount()
        {
            decimal finalAmount = 0;

            foreach (ClsTempBooking p in tempProductList)
            {
                finalAmount += p.FinalPrice;
            }
            return finalAmount;
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

        public void LoadDataFromInvoice(int invoiceId) // load to gridview
        {
            MainClear();
            Booking sale = db.Bookings
                                .Where(s => s.BookingId == invoiceId).FirstOrDefault();
            if (sale != null)
            {
                txtInvoice.Text = invoiceId.ToString();
                cmbCustomer.Text = sale.Customer.CustomerName;
                cmbEmployee.Text = sale.Employee.EmployeeName;
                txtboxFinalTotalPrice.Text = sale.FinalAmount.ToString();
                txtboxAmountPaid.Text = sale.AmountPaid.ToString();
                txtboxAmountRemain.Text = sale.AmountRemain.ToString();

                // add data to gridview

                var saleDetails = db.BookingDetails
                                .Where(sd => sd.BookingId == invoiceId);
                foreach (BookingDetail saleDetail in saleDetails)
                {
                    ClsTempBooking tempProduct = new ClsTempBooking();

                    tempProduct.Name = saleDetail.Book.Title;
                    tempProduct.Quantity = saleDetail.Quantity;
                    tempProduct.SellingPrice = saleDetail.Book.SellingPrice;
                    tempProduct.TotalPrice = saleDetail.TotalPrice;
                    tempProduct.DiscountPercentage = saleDetail.DiscountPercentage;
                    tempProduct.Discount = saleDetail.Discount;
                    tempProduct.FinalPrice = saleDetail.FinalPrice;

                    tempProductList.Add(tempProduct);
                }

                BindProductList();
            }
        }

        private void txtboxAmountPaid_Click(object sender, EventArgs e)
        {
            txtboxAmountPaid.Text= "";
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
    }
}
