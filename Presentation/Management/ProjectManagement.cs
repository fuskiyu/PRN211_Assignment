using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
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
    public partial class ProjectManagement : Form
    {
        private readonly ProjectRepository _proRepo;
        public ProjectManagement(FUH_COMPANYContext dbContext)
        {
            _proRepo = new ProjectRepository(dbContext);
            InitializeComponent();
            GetAll();
        }
        public void GetAll()
        {
            dataGridView1.DataSource = _proRepo.getAll().Select(p => new
            {   
                proNum = p.ProNum,
                proName = p.ProName,
                locNum = p.LocNum,
                depNum = p.DepNum,
                depName = p.DepNumNavigation.DepName,
                locName = p.LocNumNavigation.LocName
            }).ToList();
        }
    }
}
