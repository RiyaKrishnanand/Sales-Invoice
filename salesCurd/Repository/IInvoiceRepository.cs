using System;
using System.Collections.Generic;
using System.Text;
using salesCurd.MODELS;
using salesCurd.DATA;

namespace salesCurd.Repository
{
    
    public interface IInvoiceItemRepository
    {
        IEnumerable<InvoiceItem> GetAll();
        InvoiceItem GetById(int id);
        void Add(InvoiceItem invoiceItem);
        void Update(InvoiceItem invoiceItem);
        void Delete(int id);
    }

    
    public class InvoiceItemRepository : IInvoiceItemRepository
    {
        private readonly ApplicationContext _context;

        public InvoiceItemRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<InvoiceItem> GetAll()
        {
            return _context.InvoiceItems.ToList();
        }

        public InvoiceItem GetById(int id)
        {
            return _context.InvoiceItems.FirstOrDefault(i => i.Id == id);
        }

        public void Add(InvoiceItem invoiceItem)
        {
            _context.InvoiceItems.Add(invoiceItem);
            _context.SaveChanges();
        }

        public void Update(InvoiceItem invoiceItem)
        {
            _context.InvoiceItems.Update(invoiceItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var invoiceItem = GetById(id);
            if (invoiceItem != null)
            {
                _context.InvoiceItems.Remove(invoiceItem);
                _context.SaveChanges();
            }
        }
    }

}
