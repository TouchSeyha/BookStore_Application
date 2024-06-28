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
    public partial class frmPurchaseEntry : Form
    {
        public frmPurchaseEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private List<ClsTempSale> tempProductList = new List<ClsTempSale>();

        private void frmPurchaseEntry_Load(object sender, EventArgs e)
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

            foreach (Supplier emp in db.Suppliers)
            {
                cmbCustomer.Items.Add(emp.SupplierName);
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
            txtboxAmountPaid.Text = "0";
            txtboxAmountRemain.Text = "0";

        }

        private int GetLatestInvoiceId()
        {
            var booking = db.Purchases
                .OrderByDescending(c => c.PurchaseId)
                .FirstOrDefault();
            if (booking != null)
                return booking.PurchaseId;
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
                txtSellingprice.Text = booking.CostPrice.ToString();
                txtQuantity.Text = "10";
                txtDiscount.Text = "0";

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

        private void BindProductList()
        {
            dgvSale.Rows.Clear();
            int rowCount = 1;
            foreach (ClsTempSale product in tempProductList)
            {
                dgvSale.Rows.Add(rowCount,
                    product.Name,
                    product.PurchasePrice,
                    product.Quantity,
                    product.TotalPrice,
                    product.DiscountPercentage,
                    product.Discount,
                    product.FinalPrice);
                rowCount++;
            }
        }

        private void btnShowBookId_Click(object sender, EventArgs e)
        {
            BookListData purchaseList = new BookListData();

            purchaseList.purchaseEntry = this;
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
                decimal discountPercentage = decimal.Parse(txtDiscount.Text); // Let say we discount 15%
                decimal discount = (totalPrice * discountPercentage) / 100; ;
                decimal finalPrice = totalPrice - discount; 

                ClsTempPurchase product = new ClsTempPurchase(productName, sellingPrice, quantity, totalPrice, discountPercentage, discount, finalPrice);
                tempProductList.Add(product);

                BindProductList();
                Clear();
            }

            txtboxFinalTotalPrice.Text = GetTotalAmount().ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSale.SelectedRows.Count > 0)
            {
                string productName = dgvSale.SelectedRows[0].Cells[1].Value.ToString();
                for (int i = 0; i < tempProductList.Count; i++)
                {
                    ClsTempPurchase tempProduct = tempProductList[i];
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
            frmPurchaseList purchaseList = new frmPurchaseList();

            purchaseList.PurchaseEntry = this;
            purchaseList.ShowDialog();
        }

        private void btnClearNew_Click(object sender, EventArgs e)
        {
            MainClear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
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

            Purchase sale = new Purchase();

            sale.PurchaseId = GetLatestInvoiceId() + 1;
            sale.Employee = db.Employees
                                .Where(emp => emp.EmployeeName == employeeName)
                                .FirstOrDefault();
            sale.Supplier = db.Suppliers
                                .Where(cus => cus.SupplierName == customerName)
                                .FirstOrDefault();
            sale.TotalAmount = GetTotalAmount();
            sale.AmountPaid = decimal.Parse(txtboxAmountPaid.Text); // Need to modify show in Text task box 
            sale.AmountRemain = decimal.Parse(txtboxAmountRemain.Text); // Need to modify show in Text task box 
            sale.TotalDiscount = decimal.Parse(txtDiscount.Text);
            sale.Created = DateTime.Now;
            sale.Updated = DateTime.Now;

            db.Purchases.Add(sale);
            db.SaveChanges();

            //Save to  PurchaseDetail Booking

            foreach (ClsTempPurchase product in tempProductList)
            {
                PurchaseDetail sd = new PurchaseDetail();

                sd.Purchase = sale;
                sd.Book = db.Books
                                .Where(p => p.Title == product.Name)
                                .FirstOrDefault();
                sd.Quantity = product.Quantity;
                sd.PurchasePrice = product.PurchasePrice;
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
                    stock.Quantity += product.Quantity;
                }

                db.PurchaseDetails.Add(sd);
                db.SaveChanges();
            }
            MainClear();
            MessageBox.Show("Add Complete!");
        }

        private decimal GetTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (ClsTempPurchase p in tempProductList)
            {
                totalAmount += p.TotalPrice;
            }
            return totalAmount;
        }

        public void LoadDataFromInvoice(int invoiceId) // load to gridview
        {
            MainClear();
            Purchase sale = db.Purchases
                                .Where(s => s.PurchaseId == invoiceId).FirstOrDefault();
            if (sale != null)
            {
                txtInvoice.Text = invoiceId.ToString();
                cmbCustomer.Text = sale.Supplier.SupplierName;
                cmbEmployee.Text = sale.Employee.EmployeeName;

                // add data to gridview

                var saleDetails = db.PurchaseDetails
                                .Where(sd => sd.PurchaseId == invoiceId);
                foreach (PurchaseDetail saleDetail in saleDetails)
                {
                    ClsTempPurchase tempProduct = new ClsTempPurchase();

                    tempProduct.Name = saleDetail.Book.Title;
                    tempProduct.Quantity = saleDetail.Quantity;
                    tempProduct.PurchasePrice = saleDetail.PurchasePrice;
                    tempProduct.TotalPrice = saleDetail.TotalPrice;
                    tempProduct.DiscountPercentage = saleDetail.DiscountPercentage;
                    tempProduct.Discount = saleDetail.Discount;
                    tempProduct.FinalPrice = saleDetail.FinalPrice;

                    tempProductList.Add(tempProduct);
                }

                BindProductList();
            }
        }
    }
}
