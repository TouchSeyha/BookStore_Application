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
    public partial class AuthorListForBookEntry : Form
    {
        public AuthorListForBookEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmBookEntry bookEntry = null;

        private void AuthorListForBookEntry_Load(object sender, EventArgs e)
        {
            foreach (Author c in db.Authors)
            {
                dataGridView1.Rows.Add(c.AuthorId,
                                        c.AuthorName,
                                        c.Age,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bookEntry != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    int AuthorId = int.Parse(value);

                    bookEntry.LoadDataFrombook(AuthorId);
                    Close();
                }
            }
        }
    }
}
