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
    public partial class frmPurchaseDetail : Form
    {
        public frmPurchaseDetail()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmPurchaseDetail_Load(object sender, EventArgs e)
        {
            var sales = db.PurchaseDetails.OrderByDescending(s => s.Created);

            foreach (PurchaseDetail c in sales)
            {

                dgvSale.Rows.Add(c.PurchaseDetailId,
                                        c.PurchaseId,
                                        c.BookId,
                                        c.Book.Title,
                                        c.Quantity,
                                        c.PurchasePrice,
                                        c.TotalPrice,
                                        c.DiscountPercentage,
                                        c.Discount,
                                        c.FinalPrice,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvSale_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
