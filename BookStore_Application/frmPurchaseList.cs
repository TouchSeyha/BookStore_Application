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
    public partial class frmPurchaseList : Form
    {
        public frmPurchaseList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmPurchaseEntry PurchaseEntry = null;

        private void frmPurchaseList_Load(object sender, EventArgs e)
        {
            foreach (Purchase c in db.Purchases)
            {
                dgvPurchase.Rows.Add(c.PurchaseId,
                                        c.Employee.EmployeeName,
                                        c.Supplier.SupplierName,
                                        c.TotalAmount,
                                        c.AmountPaid,
                                        c.AmountRemain,
                                        c.TotalDiscount,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvPurchase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PurchaseEntry != null)
            {
                if (dgvPurchase.SelectedRows.Count > 0)
                {
                    string value = dgvPurchase.SelectedRows[0].Cells[0].Value.ToString();
                    int PurchaseId = int.Parse(value);

                    PurchaseEntry.LoadDataFromPurchaseId(PurchaseId;
                    Close();
                }
            }
        }
    }
}
