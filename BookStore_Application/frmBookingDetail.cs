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
    public partial class frmBookingDetail : Form
    {
        public frmBookingDetail()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmSaleEntry saleEntry = null;

        public frmBookingEntry bookingEntry = null;

        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            var sales = db.BookingDetails.OrderByDescending(s => s.Created);

            foreach (BookingDetail c in sales)
            {

                dgvSale.Rows.Add(c.BookingDetailId,
                                        c.BookingId,
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
    }
}
