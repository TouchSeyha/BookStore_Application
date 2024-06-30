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
    public partial class GenreListForBookEntry : Form
    {
        public GenreListForBookEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookEntry bookEntry = null;

        private void GenreListForBookEntry_Load(object sender, EventArgs e)
        {
            foreach (Genre c in db.Genres)
            {
                dgvGenre.Rows.Add(c.GenreId,
                                        c.GenreName,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvGenre_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bookEntry != null)
            {
                if (dgvGenre.SelectedRows.Count > 0)
                {
                    string value = dgvGenre.SelectedRows[0].Cells[0].Value.ToString();
                    int GenreId = int.Parse(value);

                    bookEntry.LoadDataFromGenre(GenreId);
                    Close();
                }
            }
        }
    }
}
