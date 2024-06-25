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
using System.Xml.Linq;

namespace BookStore_Application
{
    public partial class frmSupplierEntry : Form
    {
        public frmSupplierEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmSupplierEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear() {

            txtSupplierId.Text = (GetLatestSupplierId() + 1).ToString();
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private int GetLatestSupplierId()
        {
            var book = db.Suppliers
                .OrderByDescending(c => c.SupplierId)
                .FirstOrDefault();
            if (book != null)
                return book.SupplierId;
            return 0;
        }

        public void LoadDataFromSupplierId(int SupplierId)
        {
            var book = db.Suppliers
                            .Where(c => c.SupplierId == SupplierId)
                            .FirstOrDefault();
            if (book != null)
            {
                txtSupplierId.Text = book.SupplierId.ToString();
                txtSupplierName.Text = book.SupplierName.ToString();
                txtPhone.Text = book.Phone.ToString();
                txtAddress.Text = book.Address.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            supplier.SupplierId = GetLatestSupplierId() + 1;
            supplier.SupplierName = txtSupplierName.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Address = txtAddress.Text;
            supplier.Created = DateTime.Now;
            supplier.Updated = DateTime.Now;

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            MessageBox.Show("Supplier Added Successfully!");

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int supId = int.Parse(txtSupplierId.Text);
            string supplierName = txtSupplierName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            var supplier = db.Suppliers
                            .Where(c => c.SupplierId == supId)
                            .FirstOrDefault();

            if (supplier != null)
            {
                supplier.SupplierName = supplierName;
                supplier.Phone = phone;
                supplier.Address = address;
                supplier.Updated = DateTime.Now;

                db.SaveChanges();

                MessageBox.Show("Supplier Update Successfully!");

                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int spId = int.Parse(txtSupplierId.Text);

            var supplier = db.Suppliers
                            .Where(c => c.SupplierId == spId)
                            .FirstOrDefault();

            if(supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();

                MessageBox.Show("Delete Successfully!");

                Clear();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmSupplierList frmSupplierList = new frmSupplierList();

            frmSupplierList.SupplierEntry = this;
            frmSupplierList.Show();
        }
    }
}
