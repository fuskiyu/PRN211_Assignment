
﻿using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
﻿using System;
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
        public ProjectManagement()
        {
            InitializeComponent();

            _proRepo = new ProjectRepository();
            GetAll();
        }
        public void GetAll()
        {
            dataGridView1.DataSource = _proRepo.GetAll().Select(p => new
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
