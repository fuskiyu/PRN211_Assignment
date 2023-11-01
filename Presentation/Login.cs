using Data;
using Data.Repository;
using Microsoft.VisualBasic.Logging;
using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_StudentName
{
    public partial class Login : Form
    {
        private UserRepository userRepository;

        public Login()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;

            var user = userRepository.GetAll()
                        .Where(u => u.UserName.Equals(username) && u.Password.Equals(password))
                        .FirstOrDefault();

            if (user != null)
            {
                if (user.Role.Equals("Admin"))
                {
                    var management = new Management();
                    management.FormClosing += (sender, e) => this.Show();

                    this.Hide();
                    management.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.FormClosing += (sender, e) => this.Show();

            this.Hide();
            register.Show();
        }
    }
}
