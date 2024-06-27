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

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockEntry frmStockEntry = new frmStockEntry();
            frmStockEntry.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockList frmStockList = new frmStockList();
            frmStockList.Show();
        }

        private void bookingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookingEntry frmBookingEntry = new frmBookingEntry();
            frmBookingEntry.Show();
        }

        private void bookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookingList frmBookingList = new frmBookingList();
            frmBookingList.Show();
        }

        private void purchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseEntry frmPurchaseEntry = new frmPurchaseEntry();
            frmPurchaseEntry.Show();
        }

        private void purchaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseList frmPurchaseList = new frmPurchaseList();
            frmPurchaseList.Show();
        }

        private void saleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleList frmSaleList = new frmSaleList();
            frmSaleList.Show();
        }

        private void bookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookingDetail frmBookingDetail = new frmBookingDetail();
            frmBookingDetail.Show();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseDetail frmPurchaseDetail = new frmPurchaseDetail();
            frmPurchaseDetail.Show();
        }

        private void saleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleDetail frmSaleDetail = new frmSaleDetail();
            frmSaleDetail.Show();
        }

        private void btnToSystem_Click(object sender, EventArgs e)
        {
            frmBookSystembtn frmBookSystembtn = new frmBookSystembtn();
            frmBookSystembtn.Show();
        }
    }
}
