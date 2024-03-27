using System;
using System.Collections.Generic;
using System.Text;
using salesCurd.MODELS;


namespace salesCurd.buisness_logic
{
    
    public interface IInvoiceItemService
    {
        IEnumerable<InvoiceItem> GetAllInvoiceItems();
        InvoiceItem GetInvoiceItemById(int id);
        void AddInvoiceItem(InvoiceItem invoiceItem);
        void UpdateInvoiceItem(InvoiceItem invoiceItem);
        void DeleteInvoiceItem(int id);
    }

    
    public class InvoiceItemService : IInvoiceItemService
    {
        private readonly IInvoiceItemRepository _invoiceItemRepository;

        public InvoiceItemService(IInvoiceItemRepository invoiceItemRepository)
        {
            _invoiceItemRepository = invoiceItemRepository;
        }

        public IEnumerable<InvoiceItem> GetAllInvoiceItems()
        {
            return _invoiceItemRepository.GetAll();
        }

        public InvoiceItem GetInvoiceItemById(int id)
        {
            return _invoiceItemRepository.GetById(id);
        }

        public void AddInvoiceItem(InvoiceItem invoiceItem)
        {
            _invoiceItemRepository.Add(invoiceItem);
        }

        public void UpdateInvoiceItem(InvoiceItem invoiceItem)
        {
            _invoiceItemRepository.Update(invoiceItem);
        }

        public void DeleteInvoiceItem(int id)
        {
            _invoiceItemRepository.Delete(id);
        }
    }

}
