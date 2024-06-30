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
    public partial class AStockFrm : Form
    {
        public AStockFrm()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmStockEntry StockEntry = null;
        private void AStockFrm_Load(object sender, EventArgs e)
        {
            foreach (Book c in db.Books)
            {

                dgvBook.Rows.Add(c.BookId,
                                        c.Title,
                                        c.Author.AuthorName,
                                        c.PublishingHouse.PublishingHouseName,
                                        c.Genre.GenreName,
                                        c.TotalPage,
                                        c.CostPrice,
                                        c.SellingPrice,
                                        c.Note
                                        );
            }
        }

        private void dgvBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (StockEntry != null)
            {
                if (dgvBook.SelectedRows.Count > 0)
                {
                    string value = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
                    int BookId = int.Parse(value);

                  
                    StockEntry.LoadDataToForm(BookId);
                    Close();
                }
            }
        }
    }
}
