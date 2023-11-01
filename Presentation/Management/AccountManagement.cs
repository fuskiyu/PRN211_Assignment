using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation
{
    public partial class AccountManagement : Form
    {
        private UserRepository accountRepository;

        public AccountManagement()
        {
            InitializeComponent();

            accountRepository = new UserRepository();
            renderView();
        }

        private void renderView()
        {
            var list = accountRepository.GetAll().ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtUserName.Text);

            btnAdd.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnUpdate.Enabled = !enable;

            txtUserName.ReadOnly = !enable;
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfo.Rows[e.RowIndex];

            var username = row.Cells[0].Value.ToString();
            var password = row.Cells[1].Value.ToString();
            var role = row.Cells[2].Value.ToString();

            txtUserName.Text = username;
            txtPassword.Text = password;
            txtRole.Text = role;

            renderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var role = txtRole.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .FirstOrDefault();

            if (curAccount == null)
            {
                MessageBox.Show("UserName existed", "Error");
                return;
            }

            var user = new TblUser();

            user.UserName = username;
            user.Password = password;
            user.Role = role;

            accountRepository.Add(user);

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";

            renderView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var role = txtRole.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .First();

            curAccount.UserName = username;
            curAccount.Password = password;
            curAccount.Role = role;

            accountRepository.Update(curAccount);

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";

            renderView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;

            var curAccount = accountRepository.GetAll()
                                            .Where(a => a.UserName == username)
                                            .First();

            if (curAccount != null)
            {
                accountRepository.Delete(curAccount);
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";

            renderView();
        }
    }
}
