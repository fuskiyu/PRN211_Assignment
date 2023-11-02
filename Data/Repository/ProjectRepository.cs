using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProjectRepository : RepositoryBase<TblProject>
    {
        private readonly FUH_COMPANYContext _dbContext;
        public ProjectRepository(FUH_COMPANYContext dcContext)
        {
            _dbContext = dcContext;
        }
        public List<TblProject> getAll()
        {
            var project = _dbContext.TblProjects
                .Include(p => p.DepNumNavigation)
                .Include(p => p.LocNumNavigation)
                .Select(p => new TblProject
                {
                    ProNum = p.ProNum,
                    ProName = p.ProName,
                    DepNum = p.DepNum,
                    LocNum = p.LocNum,
                    DepNumNavigation = p.DepNumNavigation,
                    LocNumNavigation = p.LocNumNavigation,
                }).ToList();
            return project;
        }
        public TblProject getById(int id)
        {
            return _dbContext.TblProjects.FirstOrDefault(p => p.ProNum == id) ?? throw new Exception("Project not found");
        }
        public int deleteProject(int id)
        {
            var delProject = _dbContext.TblProjects.Find(id) ?? throw new Exception("Project not found");
            _dbContext.TblProjects.Remove(delProject);
            return _dbContext.SaveChanges();
        }
    }
}
