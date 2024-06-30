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
    public partial class frmAuthorEntry : Form
    {
        public frmAuthorEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmAuthorEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtAuthorId.Text = (GetLatestAuthorId() + 1).ToString();
            txtAuthorName.Text = "";
            txtAuthorAge.Text = "";
        }

        private int GetLatestAuthorId()
        {
            var author = db.Authors
                .OrderByDescending(c => c.AuthorId)
                .FirstOrDefault();
            if (author != null)
                return  author.AuthorId;
            return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAuthorName.Text) || string.IsNullOrEmpty(txtAuthorAge.Text))
            {
                MessageBox.Show("Please input every details!");
                return;
            }
            Author author = new Author();

            author.AuthorId = GetLatestAuthorId() + 1;
            author.AuthorName = txtAuthorName.Text;
            author.Age = int.Parse(txtAuthorAge.Text);
            author.Created = DateTime.Now;
            author.Updated = DateTime.Now;
            db.Authors.Add(author);
            db.SaveChanges();
            MessageBox.Show("Author Added Successfully!");

            Clear();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmAuthorList authorList = new frmAuthorList();
            authorList.authorEntry = this;
            authorList.Show();
        }

        public void LoadDataFromAuthorId(int authorId)
        {
            var author = db.Authors
                            .Where(c => c.AuthorId == authorId)
                            .FirstOrDefault();
            if (author != null)
            {
                txtAuthorId.Text = author.AuthorId.ToString();
                txtAuthorName.Text = author.AuthorName.ToString();
                txtAuthorAge.Text = author.Age.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAuthorName.Text) || string.IsNullOrEmpty(txtAuthorAge.Text))
            {
                MessageBox.Show("Choose a data to Update!");
                return;
            }
            int authorId = int.Parse(txtAuthorId.Text);
            string authorName = txtAuthorName.Text;
            int authorAge = int.Parse(txtAuthorAge.Text);

            var author = db.Authors
                            .Where(c => c.AuthorId == authorId)
                            .FirstOrDefault();
            if (author != null)
            {
                author.AuthorName = authorName;
                author.Age = authorAge; 
                author.Updated = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Update Successfully!");
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthorName.Text) || string.IsNullOrEmpty(txtAuthorAge.Text))
            {
                MessageBox.Show("Please Select a Record to Delete!");
                return;
            }

            int authorId = int.Parse(txtAuthorId.Text);

            var author = db.Authors
                            .Where(c => c.AuthorId == authorId)
                            .FirstOrDefault();
            if (author != null)
            {
                db.Authors.Remove(author);
                db.SaveChanges();
                MessageBox.Show("Delete Success");
                Clear();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}
