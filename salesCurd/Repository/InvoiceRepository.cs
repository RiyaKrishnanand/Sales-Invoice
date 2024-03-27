using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using salesCurd.DATA;
using salesCurd.MODELS;

namespace salesCurd.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationContext _context;

        public InvoiceRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _context.Invoices.ToList();
        }

        public Invoice GetInvoiceById(int id)
        {
            return _context.Invoices.Find(id);
        }

        public void AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            _context.SaveChanges();
        }

        public void DeleteInvoice(int id)
        {
            var invoice = _context.Invoices.Find(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }
    }
}
