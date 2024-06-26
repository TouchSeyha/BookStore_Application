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
    public partial class frmBookEntry : Form
    {
        public frmBookEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmBookEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtBookId.Text = (GetLatestBookId() + 1).ToString();
            txtTitle.Text = "";
            txtAuthorId.Text = "";
            txtPublishId.Text = "";
            txtGenreId.Text = "";
            txtTotalPage.Text = "";
            txtCostPrice.Text = "";
            txtSellingPrice.Text = "";
            txtNote.Text = "";
        }
           
        private int GetLatestBookId()
        {
            var book = db.Books
                .OrderByDescending(c => c.BookId)
                .FirstOrDefault();
            if (book != null)
                return book.BookId;
            return 0;
        }

        public void LoadDataFromBookId(int bookId)
        {
            var book = db.Books
                            .Where(c => c.BookId == bookId)
                            .FirstOrDefault();
            if (book != null)
            {
                txtBookId.Text = book.BookId.ToString();
                txtTitle.Text = book.Title.ToString();
                txtAuthorId.Text = book.Author.AuthorName.ToString();
                txtPublishId.Text = book.PublishingHouse.PublishingHouseName.ToString();
                txtGenreId.Text = book.Genre.GenreName.ToString();
                txtTotalPage.Text = book.TotalPage.ToString();
                txtCostPrice.Text = book.CostPrice.ToString();
                txtSellingPrice.Text = book.SellingPrice.ToString();
                txtNote.Text = book.Note.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.BookId = GetLatestBookId() + 1;
            book.Title = txtTitle.Text;
            book.AuthorId = int.Parse(txtBookId.Text);
            book.PublishingHouseId = int.Parse(txtPublishId.Text);
            book.GenreId = int.Parse(txtGenreId.Text);
            book.TotalPage = int.Parse(txtTotalPage.Text);
            book.CostPrice = decimal.Parse(txtCostPrice.Text);
            book.SellingPrice = decimal.Parse(txtSellingPrice.Text);
            book.Note = txtNote.Text;
            book.Created = DateTime.Now;
            book.Updated = DateTime.Now;

            db.Books.Add(book);
            db.SaveChanges();

            MessageBox.Show("Book Added Successfully!");

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookId.Text);
            string bookTitle = txtTitle.Text;
            string authorId = txtAuthorId.Text;
            string publishingHouseId = txtPublishId.Text;
            string genreId = txtGenreId.Text;
            int totalPage = int.Parse(txtTotalPage.Text);
            decimal costPrice = decimal.Parse(txtCostPrice.Text);
            decimal sellingPrice = decimal.Parse(txtSellingPrice.Text);
            string note = txtNote.Text;

            var book = db.Books
                            .Where(c => c.BookId == bookId)
                            .FirstOrDefault();
            if (book != null)
            {
                book.Title = bookTitle;
                book.Author.AuthorName = authorId;
                book.PublishingHouse.PublishingHouseName = publishingHouseId;
                book.Genre.GenreName = genreId;
                book.TotalPage = totalPage;
                book.CostPrice = costPrice;
                book.SellingPrice = sellingPrice;
                book.Note = note;
                book.Updated = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Update Successfully!");
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookId.Text);

            var book = db.Books
                            .Where(c => c.BookId == bookId)
                            .FirstOrDefault();
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Delete Successfully!");

                Clear();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmBookList bookList = new frmBookList();

            bookList.bookEntry = this;
            bookList.Show();
        }
    }
}
