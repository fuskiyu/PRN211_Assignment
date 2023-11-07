using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Management
{
    public partial class EmployeeManagement : Form
    {
        private EmployeeRepository employeeRepository;
        private DepartmentRepository departmentRepository;

        public EmployeeManagement()
        {
            InitializeComponent();

            employeeRepository = new EmployeeRepository();
            departmentRepository = new DepartmentRepository();

            var genderList = new object[] { "M", "F" };
            cbGender.Items.AddRange(genderList);

            var depList = departmentRepository.GetAll()
                                              .Select(d => d.DepNum.ToString())
                                              .ToArray();
            cbDepNum.Items.AddRange(depList);

            var statusList = new object[] { true, false };
            cbStatus.Items.AddRange(statusList);

            RenderView();
        }

        private void RenderView()
        {
            var list = employeeRepository.GetAll()
                                         .Include(e => e.DepNumNavigation)
                                         .OrderBy(e => e.DepNum)
                                         .Select(e => new
                                         {
                                             ID = e.EmpSsn,
                                             Name = e.EmpName,
                                             Address = e.EmpAddress,
                                             Salary = e.EmpSalary,
                                             Gender = e.EmpSex,
                                             BirthDate = e.EmpBirthdate,
                                             DepNum = e.DepNum,
                                             DepLocation = e.DepNumNavigation.DepName,
                                             SupervisorID = e.SupervisorSsn,
                                             StartDate = e.EmpStartdate,
                                             Active = e.Active,
                                             EndDate = e.EmpEnddate
                                         })
                                         .ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtID.Text);

            btnAdd.Enabled = enable;
            btnUpdate.Enabled = !enable;
            btnDetail.Enabled = !enable;

            txtID.ReadOnly = !enable;
            cbStatus.Enabled = !enable;
        }

        private void EmptyText()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
            txtSupervisorID.Text = "";
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfo.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtSalary.Text = row.Cells[3].Value?.ToString();
            cbGender.Text = row.Cells[4].Value.ToString();
            dtpBirthDate.Value = (DateTime)row.Cells[5].Value;
            cbDepNum.Text = row.Cells[6].Value?.ToString();
            txtSupervisorID.Text = row.Cells[8].Value?.ToString();
            cbStatus.Text = row.Cells[10].Value?.ToString();

            RenderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var salary = txtSalary.Text;
            var gender = cbGender.Text;
            var birthDate = dtpBirthDate.Value;
            var depNum = cbDepNum.Text;
            var supervisorID = txtSupervisorID.Text;

            try
            {
                if (String.IsNullOrEmpty(id))
                    throw new Exception("Missing id field");

                if (string.IsNullOrEmpty(name))
                    throw new Exception("Missing name field");

                if (string.IsNullOrEmpty(address))
                    throw new Exception("Missing address field");

                if (string.IsNullOrEmpty(salary))
                    throw new Exception("Missing salary field");

                if (string.IsNullOrEmpty(gender))
                    throw new Exception("Missing gender field");

                if (string.IsNullOrEmpty(depNum))
                    throw new Exception("Missing depNum field");

                if (id.Length < 11)
                {
                    throw new Exception("Id length must >= 11");
                }


                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                if (id.Equals(supervisorID))
                {
                    throw new Exception("Employee ID and Supervisor ID is the same");
                }

                if (!string.IsNullOrEmpty(supervisorID))
                {
                    var mgr = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(supervisorID))
                                                .FirstOrDefault();

                    if (mgr == null)
                    {
                        throw new Exception("Manager not found");
                    }

                    if (!mgr.Active.Value)
                    {
                        throw new Exception("Manager is not active");
                    }

                    if (mgr.DepNum != int.Parse(depNum))
                    {
                        throw new Exception("Manager is not in the same department");
                    }
                }

                var curEmp = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(id))
                                                .FirstOrDefault();

                if (curEmp != null)
                {
                    throw new Exception("Employee ID existed");
                }

                var emp = new TblEmployee()
                {
                    EmpSsn = decimal.Parse(id),
                    EmpName = name,
                    EmpAddress = address,
                    EmpSalary = !String.IsNullOrEmpty(salary) ? decimal.Parse(salary) : null,
                    EmpSex = gender,
                    EmpBirthdate = birthDate.Date,
                    DepNum = !String.IsNullOrEmpty(depNum) ? int.Parse(depNum) : null,
                    SupervisorSsn = !String.IsNullOrEmpty(supervisorID) ? decimal.Parse(supervisorID) : null,
                    EmpStartdate = DateTime.Now.Date,
                    Active = true
                };

                employeeRepository.Add(emp);
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
            var id = txtID.Text;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var salary = txtSalary.Text;
            var gender = cbGender.Text;
            var birthDate = dtpBirthDate.Value;
            var depNum = cbDepNum.Text;
            var supervisorID = txtSupervisorID.Text;
            var active = bool.Parse(cbStatus.Text);

            try
            {
                if (DateTime.Now.Year - birthDate.Year < 18)
                {
                    throw new Exception("Employee must be at least 18 years old");
                }

                if (id.Equals(supervisorID))
                {
                    throw new Exception("Employee ID and Supervisor ID is the same");
                }

                var curEmp = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(id))
                                                .First();

                if (curEmp == null)
                {
                    throw new Exception("Employee ID not found");
                }

                if (!String.IsNullOrEmpty(supervisorID))
                {
                    var mgr = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(supervisorID))
                                                .FirstOrDefault();

                    if (mgr == null)
                    {
                        throw new Exception("Manager not found");
                    }

                    if (mgr.SupervisorSsn == curEmp.EmpSsn)
                    {
                        throw new Exception($"{id} is supervisor of {supervisorID}");
                    }

                    if (!mgr.Active.Value)
                    {
                        throw new Exception("Manager is not active");
                    }

                    if (mgr.DepNum != int.Parse(depNum))
                    {
                        throw new Exception("Manager is not in the same department");
                    }

                    var depMgr = departmentRepository.GetAll()
                                                     .Where(d => d.DepNum == curEmp.DepNum && d.MgrSsn == curEmp.EmpSsn)
                                                     .FirstOrDefault();
                    if (depMgr != null)
                    {
                        throw new Exception("This employee is the department's manager");
                    }
                }

                // set end date if deactivate emp when currently active
                if (!active && curEmp.Active.Value)
                {
                    curEmp.EmpEnddate = DateTime.Now.Date;
                }
                else if (active)
                {
                    curEmp.EmpEnddate = null;
                }

                // set mgrID of employee under management to null if deactivate employee or employee department is changed
                if ((!active && curEmp.Active.Value) || curEmp.DepNum != int.Parse(depNum))
                {
                    // check to not allowing modify if emp is department's manager
                    var depMgr = departmentRepository.GetAll()
                                                     .Where(d => d.DepNum == curEmp.DepNum && d.MgrSsn == curEmp.EmpSsn)
                                                     .FirstOrDefault();
                    if (depMgr != null)
                    {
                        throw new Exception($"This employee is the manager of department");
                    }

                    var empUnderMgt = employeeRepository.GetAll()
                                                        .Where(e => e.SupervisorSsn == curEmp.EmpSsn)
                                                        .ToList();

                    foreach (var emp in empUnderMgt)
                    {
                        emp.SupervisorSsn = null;
                    }

                    employeeRepository.UpdateRange(empUnderMgt);
                }


                curEmp.EmpSsn = decimal.Parse(id);
                curEmp.EmpName = name;
                curEmp.EmpAddress = address;
                curEmp.EmpSalary = !String.IsNullOrEmpty(salary) ? decimal.Parse(salary) : null;
                curEmp.EmpSex = gender;
                curEmp.EmpBirthdate = birthDate.Date;
                curEmp.DepNum = !String.IsNullOrEmpty(depNum) ? int.Parse(depNum) : null;
                curEmp.SupervisorSsn = !String.IsNullOrEmpty(supervisorID) ? decimal.Parse(supervisorID) : null;
                curEmp.Active = active;

                employeeRepository.Update(curEmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            EmptyText();
            RenderView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyText();
            RenderView();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var form = new EmployeeDetails(decimal.Parse(txtID.Text));

            form.Show();
        }

    }
}
