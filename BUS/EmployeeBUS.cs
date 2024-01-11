using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        public Employee GetEmployeeByEmail(string email, string password)
        {
            Employee employee = employeeDAL.GetEmployeeByEmail(email,password) ;
            return employee;
        }
    }
}
