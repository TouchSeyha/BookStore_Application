using System;
using System.Data;
using System.Linq;
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

        public void LoadDataFrombook(int authorId)
        {
            var author = db.Authors
                            .Where(a => a.AuthorId == authorId)
                            .FirstOrDefault();

            if (author != null)
            {
                txtAuthorId.Text = author.AuthorId.ToString();
            }
        }

        public void LoadDataFromGenre(int genreId)
        {
            var genre = db.Genres
                            .Where(a => a.GenreId == genreId)
                            .FirstOrDefault();

            if (genre != null)
            {
                txtGenreId.Text = genre.GenreId.ToString();
            }
        }

        public void LoadDataFromPublish(int publishId)
        {

            var publish = db.PublishingHouses
                               .Where(p => p.PublishingHouseId == publishId)
                               .FirstOrDefault();

            if (publish != null)
            {
                txtPublishId.Text = publish.PublishingHouseId.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtAuthorId.Text)
                || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtPublishId.Text)
                || string.IsNullOrEmpty(txtGenreId.Text) || string.IsNullOrEmpty(txtCostPrice.Text)
                || string.IsNullOrEmpty(txtTotalPage.Text) || string.IsNullOrEmpty(txtSellingPrice.Text)
                )
            {
                MessageBox.Show("Please Input every details!");
                return;
            }
           
            Book book = new Book();

            book.BookId = GetLatestBookId() + 1;
            book.Title = txtTitle.Text;
            book.AuthorId= int.Parse(txtAuthorId.Text);
            book.PublishingHouseId=int.Parse(txtPublishId.Text);
            book.GenreId= int.Parse(txtGenreId.Text);
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
            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtAuthorId.Text)
                || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtPublishId.Text)
                || string.IsNullOrEmpty(txtGenreId.Text) || string.IsNullOrEmpty(txtCostPrice.Text)
                || string.IsNullOrEmpty(txtTotalPage.Text) || string.IsNullOrEmpty(txtSellingPrice.Text)
                )
            {
                MessageBox.Show("Choose a data to Update!");
                return;
            }


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

            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtAuthorId.Text)
                || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtPublishId.Text)
                || string.IsNullOrEmpty(txtGenreId.Text) || string.IsNullOrEmpty(txtCostPrice.Text)
                || string.IsNullOrEmpty(txtTotalPage.Text) || string.IsNullOrEmpty(txtSellingPrice.Text)
                )
            {
                MessageBox.Show("Please Select a Record to Delete!");
                return;
            }

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

        private void btnTrash_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bookStorage_Click(object sender, EventArgs e)
        {
            AuthorListForBookEntry bookEntry = new AuthorListForBookEntry();
            bookEntry.bookEntry = this;
            bookEntry.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PublishListForBookEntry house = new PublishListForBookEntry();
            house.bookEntry = this;
            house.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GenreListForBookEntry bookIn = new GenreListForBookEntry();
            bookIn.bookEntry = this;
            bookIn.Show();
        }
    }
}
