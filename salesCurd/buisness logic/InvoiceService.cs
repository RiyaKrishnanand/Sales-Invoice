using System;
using System.Collections.Generic;
using System.Text;
using salesCurd.MODELS;
using salesCurd.Repository;

namespace salesCurd.buisness_logic
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _invoiceRepository.GetAllInvoices();
        }

        public Invoice GetInvoiceById(int id)
        {
            return _invoiceRepository.GetInvoiceById(id);
        }

        public void AddInvoice(Invoice invoice)
        {
            _invoiceRepository.AddInvoice(invoice);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _invoiceRepository.UpdateInvoice(invoice);
        }

        public void DeleteInvoice(int id)
        {
            _invoiceRepository.DeleteInvoice(id);
        }
    }
}
