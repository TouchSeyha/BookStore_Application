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
    public partial class frmSaleDetail : Form
    {
        public frmSaleDetail()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookingEntry bookingEntry = null;

        private void frmSaleDetail_Load(object sender, EventArgs e)
        {
            var sales = db.SaleDetails.OrderByDescending(s => s.Created);

            foreach ( SaleDetail c in sales)
            {

                dgvSale.Rows.Add(c.SaleDetailId,
                                        c.SaleId,
                                        c.BookId,
                                        c.Book.Title,
                                        c.Quantity,
                                        c.SellingPrice,
                                        c.TotalPrice,
                                        c.DiscountPercentage,
                                        c.Discount,
                                        c.FinalPrice,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvBooking_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bookingEntry != null)
            {
                if (dgvSale.SelectedRows.Count > 0)
                {
                    string value = dgvSale.SelectedRows[0].Cells[0].Value.ToString();
                    int BookingId = int.Parse(value);

                    bookingEntry.LoadDataFromInvoice(BookingId);
                    Close();
                }
            }
        }
    }
}
