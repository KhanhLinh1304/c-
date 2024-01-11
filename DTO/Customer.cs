using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public Customer()
        {
        }

        public int IdCustomer {  get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer {  get; set; }
        public string AddressCustomer { get; set; }
     

        public Customer(int idCustomer, string nameCustomer, string phoneCustomer, string addressCustomer)
        {
            IdCustomer = idCustomer;
            NameCustomer = nameCustomer;
            PhoneCustomer = phoneCustomer;
            AddressCustomer = addressCustomer;
         
        }

       
    }
}
