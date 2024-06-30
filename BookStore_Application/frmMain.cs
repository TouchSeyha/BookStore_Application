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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
           Close();
         }

        private void authorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorEntry authorEntry = new frmAuthorEntry();
            authorEntry.Show();
        }

        private void authorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorList authorList = new frmAuthorList();
            authorList.Show();
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookEntry bookEntry = new frmBookEntry();
            bookEntry.Show();
        }

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookList bookList = new frmBookList();
            bookList.Show();
        }

        private void genreEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenreEntry genreEntry = new frmGenreEntry();
            genreEntry.Show();
        }

        private void genreListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenreList genreList = new frmGenreList();
            genreList.Show();
        }

        private void publishingHouseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishHouseEntry frmPublishHouseEntry = new frmPublishHouseEntry();
            frmPublishHouseEntry.Show();
        }

        private void publishingHouseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishHouseList frmPublishHouseList = new frmPublishHouseList();    
            frmPublishHouseList.Show();
        }

        private void supplierEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierEntry frmSupplierEntry = new frmSupplierEntry();
            frmSupplierEntry.Show();
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierList frmSupplierList = new frmSupplierList();    
            frmSupplierList.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            frmBookSystembtn frmBookSystembtn = new frmBookSystembtn();
            frmBookSystembtn.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBookingEntry frmBookingEntry = new frmBookingEntry();
            frmBookingEntry.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPurchaseEntry frmPurchaseEntry = new frmPurchaseEntry();
            frmPurchaseEntry.Show();
        }

        private void stockListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockList frmStockList = new frmStockList();
            frmStockList.Show();
        }

        private void bookingListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookingList frmBookingList = new frmBookingList();
            frmBookingList.Show();
        }

        private void purchaseListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseList frmPurchaseList = new frmPurchaseList();
            frmPurchaseList.Show();
        }

        private void saleListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleList frmSaleList = new frmSaleList();
            frmSaleList.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockEntry frmStockEntry = new frmStockEntry();
            frmStockEntry.Show();
        }

        private void bookingDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBookingDetail frmBookingDetail = new frmBookingDetail();
            frmBookingDetail.Show();
        }

        private void purchaseDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPurchaseDetail frmPurchaseDetail = new frmPurchaseDetail();
            frmPurchaseDetail.Show();
        }

        private void saleDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSaleDetail frmSaleDetail = new frmSaleDetail();
            frmSaleDetail.Show();
        }

        private void btnPurchase_MouseHover(object sender, EventArgs e)
        {
            btnPurchase.BackColor = Color.LightGreen;
        }

        private void btnPurchase_MouseLeave(object sender, EventArgs e)
        {
            btnPurchase.BackColor = Color.FromArgb(18, 52, 69);
        }

        private void btnBooking_MouseHover(object sender, EventArgs e)
        {
            btnBooking.BackColor = Color.LightGreen;
        }

        private void btnBooking_MouseLeave(object sender, EventArgs e)
        {
            btnBooking.BackColor = Color.FromArgb(18, 52, 69);
        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.LightGreen;
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.FromArgb(18, 52, 69);
        }

        private void btnPos_MouseHover(object sender, EventArgs e)
        {
            btnPos.BackColor = Color.LightGreen;
        }

        private void btnPos_MouseLeave(object sender, EventArgs e)
        {
            btnPos.BackColor = Color.MediumOrchid;
        }
    }
}
