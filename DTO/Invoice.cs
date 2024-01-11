using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Invoice
    {
        public Invoice() { }
        public string IdInvoice {  get; set; }
        public int IdCustomer { get; set; }
        public int TotalPrice { get; set; }
        public DateTime createdDate { get; set; }
        public int IdEmployee { get; set; }
        public string EmployeeName { get; set; }

        public Invoice(string idInvoice, int idCustomer, int totalPrice, DateTime createdDate, int idEmployee)
        {
            IdInvoice = idInvoice;
            IdCustomer = idCustomer;
            TotalPrice = totalPrice;
            this.createdDate = createdDate;
            IdEmployee = idEmployee;
            
        }
    }
}
