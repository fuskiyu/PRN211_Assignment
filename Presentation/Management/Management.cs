using ElectricStore_StudentName;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void btnAccountMgt_Click(object sender, EventArgs e)
        {
            var management = new AccountManagement();
            management.FormClosing += (sender, e) => this.Show();

            this.Hide();
            management.Show();
        }
    }
}
