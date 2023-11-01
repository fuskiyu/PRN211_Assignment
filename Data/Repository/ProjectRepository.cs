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
    }
}
