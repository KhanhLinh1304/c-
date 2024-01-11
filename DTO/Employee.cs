using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string NameEmployee { get; set; }
        public int PhoneEmployee { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public Employee() { }

        public Employee(int idEmployee, string nameEmployee, int phoneEmployee, string password, string email)
        {
            IdEmployee = idEmployee;
            NameEmployee = nameEmployee;
            PhoneEmployee = phoneEmployee;
            Password = password;
            Email = email;
        }
    }
}
