using POC.Core.Interfaces;
using POC.Core.Models;
using POC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateEmployee(Employees employees)
        {
            if (employees != null)
            {
                await _unitOfWork.EmployeeRepository.Add(employees);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            if (employeeId > 0)
            {
                var employees = await _unitOfWork.EmployeeRepository.GetById(employeeId);
                if (employees != null)
                {
                    _unitOfWork.EmployeeRepository.Delete(employees);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Employees>> GetAllEmployees()
        {
            var employees = await _unitOfWork.EmployeeRepository.GetAll();
            return employees;
        }

        public async Task<Employees> GetEmployeeById(int employeeId)
        {
            if (employeeId > 0)
            {
                var employees = await _unitOfWork.EmployeeRepository.GetById(employeeId);
                if (employees != null)
                {
                    return employees;
                }
            }
            return null;
        }

        public async Task<bool> UpdateEmployee(Employees employees)
        {
            if (employees != null)
            {
                var employee = await _unitOfWork.EmployeeRepository.GetById(employees.Id);
                if (employee != null)
                {
                    employee.Name = employees.Name;
                    employee.Salary = employees.Salary;
                    employee.Address = employees.Address;

                    _unitOfWork.EmployeeRepository.Update(employee);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
