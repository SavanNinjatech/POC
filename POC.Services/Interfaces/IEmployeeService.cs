using POC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<bool> CreateEmployee(Employees employees);

        Task<IEnumerable<Employees>> GetAllEmployees();

        Task<Employees> GetEmployeeById(int employeeId);

        Task<bool> UpdateEmployee(Employees employees);

        Task<bool> DeleteEmployee(int employeeId);
    }
}
