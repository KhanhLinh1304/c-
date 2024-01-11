using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class IvoiceBUS
    {
        InvoiceDAL invoiceDAL = new InvoiceDAL();
        public void CreateInvoices(Invoice invoice, List<MyItem> items)
        {
            invoiceDAL.CreateInvoices(invoice, items);
        }
        public Customer GetCustomer(int id)
        {
            return invoiceDAL.GetCustomer(id);
        }

        public List<Invoice> GetInvoiceByIdUser(int id)
        {
            return invoiceDAL.GetInvoiceByIdUser(id);
        }
        public List<MyItem> GetItemByIdInvoice(string maHD)
        {
            return invoiceDAL.GetItemByIdInvoice(maHD);
        }
    }
}
