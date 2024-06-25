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
    public partial class frmGenreList : Form
    {
        public frmGenreList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmGenreEntry genreEntry = null;

        private void frmGenreList_Load(object sender, EventArgs e)
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
            if (genreEntry != null)
            {
                if (dgvGenre.SelectedRows.Count > 0)
                {
                    string value = dgvGenre.SelectedRows[0].Cells[0].Value.ToString();
                    int GenreId = int.Parse(value);

                    genreEntry.LoadDataFromGenreId(GenreId);
                    Close();
                }
            }
        }
    }
}
