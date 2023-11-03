using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Presentation.Management
{
    public partial class DependentManagement : Form
    {
        private EmployeeRepository employeeRepository;
        private DependentRepository dependentRepository;
        public DependentManagement()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            dependentRepository = new DependentRepository();
            var genderList = new object[] { "M", "F" };
            cbdepSex.Items.AddRange(genderList);
            var relationList = new object[] { "Chồng", "Vợ" };

            cbdepRelationship.Items.AddRange(relationList);
            RenderView();
        }
        private void RenderView()
        {
            var list = dependentRepository.GetAll()
                                         .Include(e => e.EmpSsnNavigation)
                                         .Select(e => new
                                         {
                                             DependentName = e.DepName,
                                             EmployeeID = e.EmpSsnNavigation.EmpSsn,
                                             Gender = e.DepSex,
                                             BirthDate = e.DepBirthdate,
                                             Relationship = e.DepRelationship,
                                         })
                                         .ToList();
            dgvInfor.DataSource = list;

            bool enable1 = String.IsNullOrEmpty(txtempSSN.Text);
            bool enable = String.IsNullOrEmpty(txtdepName.Text);

            btnAdd.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnUpdate.Enabled = !enable;

            txtdepName.ReadOnly = !enable;
            txtempSSN.ReadOnly = !enable;

        }

        private void EmptyText()
        {
            txtdepName.Text = "";
            txtempSSN.Text = "";

        }

        private void dgvInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfor.Rows[e.RowIndex];
            txtdepName.Text = row.Cells[0].Value.ToString();
            txtempSSN.Text = row.Cells[1].Value.ToString();
            cbdepSex.Text = row.Cells[2].Value.ToString();
            dtpBirthDate.Value = (DateTime)row.Cells[3].Value;
            cbdepRelationship.Text = row.Cells[4].Value?.ToString();

            RenderView();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var depname = txtdepName.Text;
            var empid = txtempSSN.Text;
            var gender = cbdepSex.Text;
            var birthDate = dtpBirthDate.Value;
            var depRela = cbdepRelationship.Text;

            try
            {
                if (String.IsNullOrEmpty(empid))
                {
                    throw new Exception("Missing empid field");
                }

                if (String.IsNullOrEmpty(depname))
                {
                    throw new Exception("Missing depname field");
                }

                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                var curEmp = dependentRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(empid))
                                                .FirstOrDefault();

                var curDep = dependentRepository.GetAll()
                                                .Where(e => e.DepName == depname)
                                                .FirstOrDefault();
                if (curEmp != null)
                {
                    throw new Exception("Employee ID existed");
                }

                if (curDep != null)
                {
                    throw new Exception("Dependent Name existed");
                }

                var dep = new TblDependent()
                {
                    DepName = depname,
                    EmpSsn = decimal.Parse(empid),
                    DepSex = gender,
                    DepBirthdate = birthDate.Date,
                    DepRelationship = depRela
                };

                dependentRepository.Add(dep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var depname = txtdepName.Text;
            var empid = txtempSSN.Text;
            var gender = cbdepSex.Text;
            var birthDate = dtpBirthDate.Value;
            var depRela = cbdepRelationship.Text;

            try
            {

                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                var curDep = dependentRepository.GetAll()
                                                .Where(e => e.DepName == depname)
                                                .First();
                
                curDep.DepName = depname;
                curDep.EmpSsn = decimal.Parse(empid);
                curDep.DepSex = gender;
                curDep.DepBirthdate = birthDate.Date;
                curDep.DepSex = depRela;


                dependentRepository.Update(curDep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var empID = decimal.Parse(txtempSSN.Text);

            var curDep = dependentRepository.GetAll()
                                                .Where(e => e.EmpSsn == empID)
                                                .First();

            if (curDep == null)
            {
                MessageBox.Show("Employee ID not found", "Error");
                return;
            }

            dependentRepository.Delete(curDep);

            EmptyText();
            RenderView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyText();
            RenderView();
        }
    }
}
