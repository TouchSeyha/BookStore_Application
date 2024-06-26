using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void frmBookingEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtInvoice.Text = (GetLatestBookingId() + 1).ToString();
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

        private int GetLatestBookingId()
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
            var booking = db.Bookings
                            .Where(c => c.BookingId == bookingId)
                            .FirstOrDefault();
            if (booking != null)
            {
                txtBookingId.Text = booking.BookingId.ToString();
                txtEmployeeId.Text = booking.EmployeeId.ToString();
                txtCustomerId.Text = booking.CustomerId.ToString();
                txtTotalAmount.Text = booking.TotalAmount.ToString();
                txtTotalDiscount.Text = booking.TotalDiscount.ToString();
                txtFinalAmount.Text = booking.FinalAmount.ToString();
                txtAmountPaid.Text = booking.AmountPaid.ToString();
                txtAmountRemain.Text = booking.AmountRemain.ToString();
                txtNote.Text = booking.Note.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
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
                double sellingPrice = double.Parse(txtSellingprice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                double totalPrice = sellingPrice * quantity;
                string totalDiscount = txtBookTitle.Tag.ToString();

                ClsTempProduct product = new ClsTempProduct(productName, sellingPrice, quantity, totalPrice, unit);
                tempProductList.Add(product);

                BindProductList();
                Clear();
            }

            txtFinalTotalPrice.Text = GetTotalAmount().ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookingId = int.Parse(txtBookingId.Text);
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
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookingsId = int.Parse(txtBookingId.Text);

            var booked = db.Bookings
                            .Where(c => c.BookingId == bookingsId)
                            .FirstOrDefault();

            if (booked != null)
            {
                db.Bookings.Remove(booked);
                db.SaveChanges();

                MessageBox.Show("Booking Delete Successfully!");

                Clear();
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
    }
}
