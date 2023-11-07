using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation.Management
{
    public partial class DepartmentManagement : Form
    {
        private DepartmentRepository departmentRepository;
        private EmployeeRepository employeeRepository;

        public DepartmentManagement()
        {
            InitializeComponent();

            departmentRepository = new DepartmentRepository();
            employeeRepository = new EmployeeRepository();
            RenderView();
        }

        private void RenderView()
        {
            var list = departmentRepository.GetAll().ToList();
            dgvInfo.DataSource = list;

            bool enable = String.IsNullOrEmpty(txtDepNum.Text);

            btnAdd.Enabled = enable;
            btnUpdate.Enabled = !enable;

            txtDepNum.ReadOnly = !enable;
        }

        private void EmptyText()
        {
            txtDepNum.Text = "";
            txtDepName.Text = "";
            txtMgrID.Text = "";
        }

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvInfo.Rows[e.RowIndex];

            var depNum = row.Cells[0].Value.ToString();
            var depName = row.Cells[1].Value.ToString();
            var mgrID = row.Cells[2].Value?.ToString();

            txtDepNum.Text = depNum;
            txtDepName.Text = depName;
            txtMgrID.Text = mgrID;

            RenderView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var depNum = txtDepNum.Text;
            var depName = txtDepName.Text;
            var mgrID = txtMgrID.Text;

            if (String.IsNullOrEmpty(depNum) || String.IsNullOrEmpty(depName))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            try
            {
                var curDep = departmentRepository.GetAll()
                                                .Where(a => a.DepNum == int.Parse(depNum))
                                                .FirstOrDefault();

                // check if department id existed
                if (curDep != null)
                    throw new Exception("Department id existed");

                if (!string.IsNullOrEmpty(mgrID))
                {
                    // not allowing 1 manager of 2 department
                    if (departmentRepository.GetAll().Any(d => d.MgrSsn == decimal.Parse(mgrID)))
                    {
                        throw new Exception("Manager already assigned");
                    }

                    var mgr = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(mgrID)) 
                                                .FirstOrDefault();
                    if (mgr == null)
                        throw new Exception("Manager not found");

                    if (!mgr.Active.Value)
                        throw new Exception("Manager is not active");
                
                    if (mgr.DepNum != int.Parse(depNum))
                        throw new Exception("Manager is not in the department");                    
                }


                var dep = new TblDepartment();
                dep.DepNum = int.Parse(depNum);
                dep.DepName = depName;
                dep.MgrSsn = !String.IsNullOrEmpty(mgrID) ? decimal.Parse(mgrID) : null;

                if (!string.IsNullOrEmpty(mgrID))
                {
                    dep.MgrAssDate = DateTime.Now.Date;
                }

                departmentRepository.Add(dep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            EmptyText();
            RenderView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var depNum = txtDepNum.Text;
            var depName = txtDepName.Text;
            var mgrID = txtMgrID.Text;

            if (String.IsNullOrEmpty(depNum) || String.IsNullOrEmpty(depName))
            {
                MessageBox.Show("Missing required field", "Error");
                return;
            }

            try
            {
                var curDep = departmentRepository.GetAll()
                                                .Where(a => a.DepNum == int.Parse(depNum))
                                                .FirstOrDefault();

                if (curDep == null)
                {
                    throw new Exception("Department not found");
                }

                if (!string.IsNullOrEmpty(mgrID))
                {
                    // not allowing 1 manager of 2 department
                    if (departmentRepository.GetAll().Any(d => d.MgrSsn == decimal.Parse(mgrID) && d.DepNum != int.Parse(depNum)))
                    {
                        throw new Exception("Manager already assigned");
                    }

                
                    var mgr = employeeRepository.GetAll()
                                                .Where(e => e.EmpSsn == decimal.Parse(mgrID))
                                                .FirstOrDefault();
                    if (mgr == null)
                    {
                        throw new Exception("Manager not found");
                    }

                    if (!mgr.Active.Value)
                        throw new Exception("Manager is not active");

                    if (mgr.DepNum != int.Parse(depNum))
                        throw new Exception("Manager is not in the department");

                    // set manager of employee to null when employee become a department's manager
                    // and employee is under a management
                    if (mgr.SupervisorSsn != null)
                    {
                        var confirmResult = MessageBox.Show("This employee is currently under other's management and will be set to null",
                                         "Confirm Modifying!!",
                                         MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            mgr.SupervisorSsn = null;
                            employeeRepository.Update(mgr);                        
                        }
                        else
                        {
                            // not updating if user chooses "No"
                            return;
                        }
                    }

                }



                if (!string.IsNullOrEmpty(mgrID) && curDep.MgrSsn != decimal.Parse(mgrID))
                {
                    curDep.MgrAssDate = DateTime.Now.Date;
                }

                curDep.DepNum = int.Parse(depNum);
                curDep.DepName = depName;
                curDep.MgrSsn = !String.IsNullOrEmpty(mgrID) ? decimal.Parse(mgrID) : null;

                departmentRepository.Update(curDep);
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
    }
}
