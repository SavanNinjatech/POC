using POC.Core.Interfaces;
using POC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
