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
    public partial class frmSaleEntry : Form
    {
        public frmSaleEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private List<ClsTempProduct> tempProductList = new List<ClsTempProduct>();

        private void frmSaleEntry_Load(object sender, EventArgs e)
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
            dgvSale.Rows.Clear();
            tempProductList.Clear();

            txtboxFinalTotalPrice.Text = "0";
            txtboxAmountRemain.Text = "0";
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

        public void LoadDataToForm(int productId) // Don't know what data to load
        {
           /* var product = db.Sales.Where(p => p.SaleId == productId).FirstOrDefault();
            if (product != null)
            {
                txtBookTitle.Text = product.;
                txtSellingprice.Text = product.SellingPrice.ToString();
                txtQuantity.Text = "1";
                txtDiscount.Text = product.TotalDiscount;

                Stock stock = db.Stocks
                            .Where(s => s.StockId == productId).FirstOrDefault();
                if (stock != null)
                {
                    lblStock.Text = stock.Quantity.ToString();
                }

                CalculateTotalPrice();
            }*/
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

        private void BindProductList()
        {
            dgvSale.Rows.Clear();
            int rowCount = 1;
            foreach (ClsTempProduct product in tempProductList)
            {
                dgvSale.Rows.Add(rowCount,
                    product.Name,
                    product.SellingPrice,
                    product.Quantity,
                    product.TotalPrice,
                    product.TotalDiscount);
                rowCount++;
            }
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

        public void LoadDataFromInvoice(int invoiceId) // don't know what data to load
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnClearNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmSaleList saleList = new frmSaleList();

            saleList.saleEntry = this;
            saleList.Show();
        }


        private void btnShowBookId_Click(object sender, EventArgs e)
        {
            frmBookingList bookingList = new frmBookingList();

            // bookingList.bookingEntry = this;
            bookingList.ShowDialog();
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
    }
}
