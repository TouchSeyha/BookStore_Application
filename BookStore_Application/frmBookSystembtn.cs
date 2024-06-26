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
    public partial class frmBookSystembtn : Form
    {
        public frmBookSystembtn()
        {
            InitializeComponent();
        }

        private BookStoreDBEntities db = new BookStoreDBEntities();
        private void frmBookSystembtn_Load(object sender, EventArgs e)
        {

        }
    }
}
