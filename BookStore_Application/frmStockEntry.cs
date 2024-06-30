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
    public partial class frmStockEntry : Form
    {
        public frmStockEntry()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();


        private void frmStockEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear() 
        {
            txtStockId.Text = (GetLatestStockId() + 1).ToString();
            txtBookId.Text = "";
            txtQuantity.Text = "";
        }


        private int GetLatestStockId()
        {
            var book = db.Stocks
                .OrderByDescending(c => c.StockId)
                .FirstOrDefault();
            if (book != null)
                return book.StockId;
            return 0;
        }

        public void LoadDataFromStockId(int stockId)
        {
            var book = db.Stocks
                            .Where(c => c.StockId == stockId)
                            .FirstOrDefault();
            if (book != null)
            {
                txtStockId.Text = book.StockId.ToString();
                txtBookId.Text = book.BookId.ToString();
                txtQuantity.Text = book.Quantity.ToString();
            }
        }

        public void LoadDataToForm(int stockID) 
        {
           
            var stock = db.Books
                        .Where(b => b.BookId == stockID)
                        .FirstOrDefault();

            if( stock != null)
            {

                txtBookId.Text = stock.BookId.ToString();
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear ();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Input every details!");
                return;
            }
                

            // Check if the bookid exist
            int bookId = int.Parse(txtBookId.Text);
            if (!db.Books.Any(b => b.BookId == bookId))
            {
                MessageBox.Show("Book ID does not exist.");
                return;
            }

            Stock stock = new Stock();
            int Quantity = int.Parse(txtQuantity.Text);

            stock.StockId = GetLatestStockId() + 1;
            stock.BookId = int.Parse(txtBookId.Text);
            Quantity += stock.Quantity;
            stock.Created = DateTime.Now;
            stock.Updated = DateTime.Now;

            db.Stocks.Add(stock);
            db.SaveChanges();

            MessageBox.Show("Stock Added Successfully!");

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Choose a Records to Update!");
                return;
            }

            int stockId = int.Parse(txtStockId.Text);
            int bookId = int.Parse(txtBookId.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            
            var stock = db.Stocks
                            .Where(c => c.StockId == stockId)
                            .FirstOrDefault();

            if(stock != null)
            {
                stock.BookId = bookId;
                stock.Quantity = Quantity;
                stock.Updated = DateTime.Now;

                db.SaveChanges ();

                MessageBox.Show("Stock Update Successfully!");

                Clear();
            }
            else
            {
                MessageBox.Show("Stock Update Failed: Stock ID not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookId.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Choose a Records to Delete!");
                return;
            }


            int stId = int.Parse(txtStockId.Text);

            var stock = db.Stocks
                            .Where(c => c.StockId == stId)
                            .FirstOrDefault();

            if (stock != null)
            {
                db.Stocks.Remove(stock);
                db.SaveChanges();

                MessageBox.Show("Stock Delete Successfully!");

                Clear();
            }
            else
            {
                MessageBox.Show("Stock ID or Book ID not found!");
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmStockList frmStockList = new frmStockList();

            frmStockList.StockEntry = this;
            frmStockList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AStockFrm bookList = new AStockFrm();

            bookList.StockEntry = this;
            bookList.ShowDialog();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
                pictureBox1.BackColor = Color.LightBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(6, 17, 23);
        }
    }
}
