using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookStore_Application
{
    public partial class frmPublishHouseEntry : Form
    {
        public frmPublishHouseEntry()
        {
            InitializeComponent();
        }
        private BookStoreDBEntities db = new BookStoreDBEntities();

        private void frmPublishHouseEntry_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtPublishId.Text = (GetLatestPublishId() + 1).ToString();
            txtPublishName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private int GetLatestPublishId()
        {
            var book = db.PublishingHouses
                .OrderByDescending(c => c.PublishingHouseId)
                .FirstOrDefault();
            if (book != null)
                return book.PublishingHouseId;
            return 0;
        }

        public void LoadDataFromPublishHouseId(int HouseId)
        {
            var book = db.PublishingHouses
                            .Where(c => c.PublishingHouseId == HouseId)
                            .FirstOrDefault();
            if (book != null)
            {
                txtPublishId.Text = book.PublishingHouseId.ToString();
                txtPublishName.Text = book.PublishingHouseName.ToString();
                txtPhone.Text = book.Phone.ToString();
                txtAddress.Text = book.Address.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPublishName.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtPublishId.Text))
            {
                MessageBox.Show("Please Input every details!");
                return;
            }

            PublishingHouse house = new PublishingHouse();

            house.PublishingHouseId = GetLatestPublishId() + 1;
            house.PublishingHouseName = txtPublishName.Text;
            house.Address = txtAddress.Text;
            house.Phone = txtPhone.Text;
            house.Created = DateTime.Now;
            house.Updated = DateTime.Now;

            db.PublishingHouses.Add(house);
            db.SaveChanges();

            MessageBox.Show("Publish House Added Successfully!");

            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPublishName.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtPublishId.Text))
            {
                MessageBox.Show("Please Choose a Record to Update!");
                return;
            }

            int pbId = int.Parse(txtPublishId.Text);
            string pdName = txtPublishName.Text;
            string pdAddress = txtAddress.Text;
            string pdPhone = txtPhone.Text;

            var house = db.PublishingHouses
                            .Where(c => c.PublishingHouseId == pbId)
                            .FirstOrDefault();
            if (house != null)
            {
                house.PublishingHouseName = pdName;
                house.Phone = pdPhone;
                house.Address = pdAddress;
                house.Updated = DateTime.Now;

                db.SaveChanges();

                MessageBox.Show("Update Successfully!");

                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPublishName.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtPublishId.Text))
            {
                MessageBox.Show("Please Choose a Record to Delete!");
                return;
            }

            int pbId = int.Parse(txtPublishId.Text);

            var house = db.PublishingHouses
                            .Where(c => c.PublishingHouseId == pbId)
                            .FirstOrDefault();

            if (house != null)
            {
                db.PublishingHouses.Remove(house);
                db.SaveChanges();
                MessageBox.Show("Delete Successfully!");

                Clear();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmPublishHouseList frmPublishHouseList = new frmPublishHouseList();

            frmPublishHouseList.PublishHouseEntry = this;
            frmPublishHouseList.Show();
        }
    }
}
