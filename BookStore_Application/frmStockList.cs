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
    public partial class frmStockList : Form
    {
        public frmStockList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmStockEntry StockEntry = null;
        private void frmStockList_Load(object sender, EventArgs e)
        {
            foreach (Stock c in db.Stocks)
            {
                dgvStock.Rows.Add(c.StockId,
                                        c.Book.Title,
                                        c.Quantity,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (StockEntry != null)
            {
                if (dgvStock.SelectedRows.Count > 0)
                {
                    string value = dgvStock.SelectedRows[0].Cells[0].Value.ToString();
                    int StockId = int.Parse(value);

                    StockEntry.LoadDataFromStockId(StockId);
                    Close();
                }
            }
        }
    }
}
