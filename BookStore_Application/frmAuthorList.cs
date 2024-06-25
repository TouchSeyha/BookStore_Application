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
    public partial class frmAuthorList : Form
    {
        public frmAuthorList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmAuthorEntry authorEntry = null;

        private void frmAuthorList_Load(object sender, EventArgs e)
        {
            foreach (Author c in db.Authors)
            {
                dgvAuthor.Rows.Add(c.AuthorId,
                                        c.AuthorName,
                                        c.Age,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvAuthor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (authorEntry != null)
            {
                if (dgvAuthor.SelectedRows.Count > 0)
                {
                    string value = dgvAuthor.SelectedRows[0].Cells[0].Value.ToString();
                    int AuthorId = int.Parse(value);

                    authorEntry.LoadDataFromAuthorId(AuthorId);
                    Close();
                }
            }
        }

    }
}
