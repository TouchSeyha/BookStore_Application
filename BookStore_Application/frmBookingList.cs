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

namespace BookStore_Application
{
    public partial class frmBookingList : Form
    {
        public frmBookingList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookingEntry bookingEntry = null;

        public frmBookEntry bookEntry = null;

        private void frmBookingList_Load(object sender, EventArgs e)
        {
            foreach (Booking c in db.Bookings)
            {
                dgvBooking.Rows.Add(c.BookingId,
                                        c.Employee.EmployeeName,
                                        c.Customer.CustomerName,
                                        c.TotalAmount,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvBooking_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (bookingEntry != null)
            {
                if (dgvBooking.SelectedRows.Count > 0)
                {
                    string value = dgvBooking.SelectedRows[0].Cells[0].Value.ToString();
                    int BookingId = int.Parse(value);

                    bookingEntry.LoadDataFromInvoice(BookingId);
                    Close();
                }
            }
        }
    }
}
