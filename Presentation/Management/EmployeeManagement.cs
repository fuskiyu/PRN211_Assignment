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

namespace Presentation.Management
{
    public partial class EmployeeManagement : Form
    {
        private EmployeeRepository employeeRepository;

        public EmployeeManagement()
        {
            InitializeComponent();

            employeeRepository = new EmployeeRepository();
            renderView();
        }

        private void renderView()
        {
            var list = employeeRepository.GetAll().ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtID.Text);

            btnAdd.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnUpdate.Enabled = !enable;

            txtID.ReadOnly = !enable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
