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
    public partial class frmPublishHouseList : Form
    {
        public frmPublishHouseList()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();

        public frmPublishHouseEntry PublishHouseEntry = null;

        private void frmPublishHouseList_Load(object sender, EventArgs e)
        {
            foreach (PublishingHouse c in db.PublishingHouses)
            {
                dgvPublish.Rows.Add(c.PublishingHouseId,
                                        c.PublishingHouseName,
                                        c.Address,
                                        c.Phone,
                                        c.Created,
                                        c.Updated);
            }
        }

        private void dgvPublish_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PublishHouseEntry != null) 
            {
                if (dgvPublish.SelectedRows.Count > 0)
                {
                    string value = dgvPublish.SelectedRows[0].Cells[0].Value.ToString();
                    int HouseId = int.Parse(value);

                    PublishHouseEntry.LoadDataFromPublishHouseId(HouseId);
                    Close();
                }
            }
        }
    }
}
