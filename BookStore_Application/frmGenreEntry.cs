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
    public partial class frmGenreEntry : Form
    {
        public frmGenreEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmGenreEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtGenreId.Text = (GetLatestGenreId() + 1).ToString();
            txtGenreName.Text = "";
        }

        private int GetLatestGenreId()
        {
            var genre = db.Genres
                .OrderByDescending(c => c.GenreId)
                .FirstOrDefault();
            if (genre != null)
                return genre.GenreId;
            return 0;
        }

        public void LoadDataFromGenreId(int bookId)
        {
            var genre = db.Genres
                .OrderByDescending(c => c.GenreId)
                .FirstOrDefault();
            if (genre != null)
            {
                txtGenreId.Text = genre.GenreId.ToString();
                txtGenreName.Text = genre.GenreName.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear ();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                MessageBox.Show("Please Enter the Genre Name");
                return;
            }
            Genre genre = new Genre();

            genre.GenreId = GetLatestGenreId() + 1;
            genre.GenreName = txtGenreName.Text;
            genre.Created = DateTime.Now;
            genre.Updated = DateTime.Now;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Genre Added Successfully!");

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                MessageBox.Show("Please Enter the Genre Name");
                return;
            }

            int authorId = int.Parse(txtGenreId.Text);
            string authorName = txtGenreName.Text;
     

            var author = db.Genres
                            .Where(c => c.GenreId == authorId)
                            .FirstOrDefault();
            if (author != null)
            {
                author.GenreName = authorName;
                author.Updated = DateTime.Now;
                db.SaveChanges();
                MessageBox.Show("Update Successfully!");
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                MessageBox.Show("Please Enter the Genre Name");
                return;
            }

            int bookId = int.Parse(txtGenreId.Text);

            var book = db.Genres
                            .Where(c => c.GenreId == bookId)
                            .FirstOrDefault();
            if (book != null)
            {
                db.Genres.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Delete Successfully!");

                Clear();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmGenreList GenreList = new frmGenreList();

            GenreList.genreEntry = this;
            GenreList.Show();
        }
    }
}
