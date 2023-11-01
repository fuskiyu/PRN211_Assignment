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
        public ProjectRepository getAll()
        {
            return _dbContext.TblProjects.ToList();
        }
        public ProjectRepository getById(int id)
        {
            return _dbContext.TblProjects.FirstOrDefault(p => p.Id == id);
        }
        public int deleteProject(int id)
        {
            _dbContext.TblProjects.Remove(p => p.Id == id);
        }
    }
}
