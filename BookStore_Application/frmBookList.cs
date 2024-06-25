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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookEntry bookEntry = null;

        private void frmBookList_Load(object sender, EventArgs e)
        {
            foreach (Book c in db.Books)
            {
                dgvBook.Rows.Add(c.BookId,
                                        c.Title,
                                        c.AuthorId,
                                        c.PublishingHouseId,
                                        c.GenreId,
                                        c.TotalPage,
                                        c.CostPrice,
                                        c.SellingPrice,
                                        c.Note,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bookEntry != null)
            {
                if (dgvBook.SelectedRows.Count > 0)
                {
                    string value = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
                    int BookId = int.Parse(value);

                    bookEntry.LoadDataFromBookId(BookId);
                    Close();
                }
            }
        }
    }
}
