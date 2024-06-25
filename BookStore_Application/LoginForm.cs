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
    public partial class LoginForm : Form
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = txtUsername.Text;
            string passwordInput = txtPassword.Text;

            if (string.IsNullOrEmpty(usernameInput))
            {
                MessageBox.Show("Please input Username");
                return;
            }

            if (string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please input password");
                return;
            }

            var employee = db.Employees
                            .Where(emp => emp.Username == usernameInput &&
                            emp.Password == passwordInput)
                            .FirstOrDefault();
            if (employee != null)
            {

                AppManager.GetInstance().loginEmployee = employee;


                frmMain main = new frmMain();
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
