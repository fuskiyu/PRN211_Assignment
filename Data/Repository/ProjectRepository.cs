using Data.Models;
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
            return _dbContext.TblProjects.ToList();
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
