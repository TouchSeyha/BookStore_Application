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

        private List<ClsTempProduct> tempProductList = new List<ClsTempProduct>();

        private void frmBookingEntry_Load(object sender, EventArgs e)
        {
            Clear();
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
            txtDiscount.Text = "";
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

            txtboxFinalTotalPrice.Text = "0";
            txtboxAmountRemain.Text = "0";
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

        public void LoadDataFromBookingId(int bookingId)
        {
            var book = db.Bookings
                            .Where(c => c.BookingId == bookingId)
                            .FirstOrDefault();
            if (book != null)
            {
                /*txtBookId.Text = book.BookId.ToString();
                txtTitle.Text = book.Title.ToString();
                txtAuthorId.Text = book.BookId.ToString();
                txtPublishId.Text = book.PublishingHouseId.ToString();
                txtGenreId.Text = book.GenreId.ToString();
                txtTotalPage.Text = book.TotalPage.ToString();
                txtCostPrice.Text = book.CostPrice.ToString();
                txtSellingPrice.Text = book.SellingPrice.ToString();
                txtNote.Text = book.Note.ToString();*/
            }
        }

        public void LoadDataToForm(int bookingId)
        {
            var booking = db.Books
                            .Where(c => c.BookId == bookingId)
                            .FirstOrDefault();
            if (booking != null)
            {
                txtBookTitle.Text = booking.Title;
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
                decimal sellingPrice = int.Parse(txtSellingprice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                decimal totalPrice = sellingPrice * quantity;
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MainClear();
        }
        //Create New ClsTempBooking
        private void BindProductList()
        {
            dgvBooking.Rows.Clear();
            int rowCount = 1;
            foreach (ClsTempProduct product in tempProductList)
            {
                dgvBooking.Rows.Add(rowCount,
                    product.Name,
                    product.SellingPrice,
                    product.Quantity,
                    product.TotalPrice,
                    product.TotalDiscount);
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
                decimal sellingPrice = int.Parse(txtSellingprice.Text);
                int quantity = int.Parse(txtQuantity.Text);
                decimal totalPrice = sellingPrice * quantity;
                decimal totalDiscount = (totalPrice / 10) * 100;

                ClsTempProduct product = new ClsTempProduct(productName, sellingPrice, quantity, totalPrice, totalDiscount);
                tempProductList.Add(product);

                BindProductList();
                Clear();
            }

            txtboxFinalTotalPrice.Text = GetTotalAmount().ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*int bookingId = int.Parse(txtBookingId.Text);
            int empId = int.Parse(txtEmployeeId.Text);
            int cusId = int.Parse(txtCustomerId.Text);
            decimal totalAm = decimal.Parse(txtTotalAmount.Text);
            decimal totalDis = decimal.Parse(txtTotalDiscount.Text);
            decimal finalAm = decimal.Parse(txtFinalAmount.Text);
            decimal amountPaid = decimal.Parse(txtAmountPaid.Text);
            decimal amountRemain = decimal.Parse(txtAmountRemain.Text);
            string note = txtNote.Text;

            var booking = db.Bookings
                        .Where(c => c.BookingId == bookingId)
                        .FirstOrDefault();

            if (booking != null)
            {
                booking.EmployeeId = int.Parse(txtEmployeeId.Text);
                booking.CustomerId = int.Parse(txtCustomerId.Text);
                booking.TotalAmount = decimal.Parse(txtTotalAmount.Text);
                booking.TotalDiscount = decimal.Parse(txtTotalDiscount.Text);
                booking.FinalAmount = decimal.Parse(txtFinalAmount.Text);
                booking.AmountPaid = decimal.Parse(txtAmountPaid.Text);
                booking.AmountRemain = decimal.Parse(txtAmountRemain.Text);
                booking.Note = txtNote.Text;
                booking.Updated = DateTime.Now;

                db.SaveChanges();
                MessageBox.Show("Booking Update Successfully!");
                Clear();
            }
            else
            {
                MessageBox.Show("Booking Update Failed: Booking ID not found.");
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count > 0)
            {
                string productName = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                for (int i = 0; i < tempProductList.Count; i++)
                {
                    ClsTempProduct tempProduct = tempProductList[i];
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
            frmBookList bookList = new frmBookList();

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

            if (string.IsNullOrEmpty(customerName) ||
                string.IsNullOrEmpty(employeeName) ||
                dgvBooking.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Customer and Employee!");
                return;
            }

            Sale sale = new Sale();
            sale.SaleId = GetLatestInvoiceId() + 1;
            sale.Employee = db.Employees
                                .Where(emp => emp.EmployeeName == employeeName)
                                .FirstOrDefault();
            sale.Customer = db.Customers
                                .Where(cus => cus.CustomerName == customerName)
                                .FirstOrDefault();
            // sale.TotalAmount = GetTotalAmount();
            sale.AmountRemain = decimal.Parse(txtAmountRemain.Text);
            sale.Created = DateTime.Now;
            sale.Updated = DateTime.Now;

            db.Sales.Add(sale);
            db.SaveChanges();

            //Save to BookingDetail

            foreach (ClsTempProduct product in tempProductList)
            {
                SaleDetail sd = new SaleDetail();
                sd.Sale = sale;
                sd.Book = db.Books
                                .Where(p => p.Title == product.Name)
                                .FirstOrDefault();
                sd.Quantity = product.Quantity;
                sd.TotalPrice = product.TotalPrice;
                sd.DiscountPercentage = product.TotalPrice / 100; // discount error
                sd.Discount = product.TotalPrice / 100;

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
            MainClear();
            MessageBox.Show("Add Complete!");
        }

        private decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ClsTempProduct p in tempProductList)
            {
                totalAmount += p.TotalPrice;
            }
            return totalAmount;
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

        public void LoadDataFromInvoice(int invoiceId)
        {
            MainClear();
            Sale sale = db.Sales
                                .Where(s => s.SaleId == invoiceId).FirstOrDefault();
            if (sale != null)
            {
                txtInvoice.Text = invoiceId.ToString();
                cmbCustomer.Text = sale.Customer.CustomerName;
                cmbEmployee.Text = sale.Employee.EmployeeName;

                // add data to gridview

                var saleDetails = db.SaleDetails
                                .Where(sd => sd.SaleId == invoiceId);
                foreach (SaleDetail saleDetail in saleDetails)
                {
                    ClsTempProduct tempProduct = new ClsTempProduct();
                    tempProduct.Name = saleDetail.Book.Title;
                    tempProduct.Quantity = saleDetail.Quantity;
                    tempProduct.SellingPrice = saleDetail.Book.SellingPrice;
                    tempProduct.TotalPrice = saleDetail.TotalPrice;
                    tempProduct.TotalDiscount = saleDetail.Discount; // Discount Possible Error
                    tempProductList.Add(tempProduct);
                }

                BindProductList();
            }
        }
    }
}
