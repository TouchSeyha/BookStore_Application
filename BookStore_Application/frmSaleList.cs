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
    public partial class frmSaleList : Form
    {
        public frmSaleList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookSystembtn saleEntry = null;

        private void frmSaleList_Load(object sender, EventArgs e)
        {
            var sales = db.Sales.OrderByDescending(s => s.Created);

            foreach (Sale c in sales)
            {

                dgvSale.Rows.Add(c.SaleId,
                                        c.Employee.EmployeeName,
                                        c.Customer.CustomerName,
                                        c.TotalAmount,
                                        c.TotalDiscount,
                                        c.FinalAmount,
                                        c.AmountPaid,
                                        c.AmountRemain,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvSale_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (saleEntry != null)
            {
                if (dgvSale.SelectedRows.Count > 0)
                {
                    string value = dgvSale.SelectedRows[0].Cells[0].Value.ToString();
                    int BookingId = int.Parse(value);

                    saleEntry.LoadDataFromInvoice(BookingId);
                    Close();
                }
            }
        }
    }
}
