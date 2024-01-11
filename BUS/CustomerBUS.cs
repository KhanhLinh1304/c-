using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public List<Customer> getListCustomer()
        {
            return customerDAL.getListCustomer();

        }
        public void InsertCustomer(Customer customer)
        {
            customerDAL.InsertCustomer(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            customerDAL.UpdateCustomer(customer);
        }
        public void DeleteCustomer(int id)
        {
            customerDAL.DeleteCustomer(id);
        }
        public List<Customer> SearchCustomer(string sdtkh)
        {
            return customerDAL.SearchCustomer(sdtkh);
        }
        public Boolean CheckExistCustomerByPhone(string sdt)
        {
            return customerDAL.CheckExistCustomerByPhone(sdt);
        }
        public Boolean CheckExistCustomerById(int id)
        {
            return customerDAL.CheckExistCustomerById(id);
        }
    }
}
