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
    public partial class frmSupplierList : Form
    {
        public frmSupplierList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmSupplierEntry SupplierEntry = null;

        public frmPurchaseEntry purchaseEntry = null;

        private void frmSupplierList_Load(object sender, EventArgs e)
        {
            foreach (Supplier c in db.Suppliers)
            {
                dgvSupplier.Rows.Add(c.SupplierId,
                                        c.SupplierName,
                                        c.Phone,
                                        c.Address,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvSupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SupplierEntry != null) {

                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    string value = dgvSupplier.SelectedRows[0].Cells[0].Value.ToString();
                    int SupplierId = int.Parse(value);

                    SupplierEntry.LoadDataFromSupplierId(SupplierId);
                    Close();
                }
            }
        }
    }
}
