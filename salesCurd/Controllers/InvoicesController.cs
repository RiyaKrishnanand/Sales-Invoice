using System;
using System.Collections.Generic;
using System.Text;
using salesCurd.MODELS;
using salesCurd.buisness_logic;
using Microsoft.AspNetCore.Mvc;

namespace salesCurd.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceItemsController : ControllerBase
    {
        private readonly IInvoiceItemService _invoiceItemService;

        public InvoiceItemsController(IInvoiceItemService invoiceItemService)
        {
            _invoiceItemService = invoiceItemService;
        }

       
        [HttpGet]
        public IEnumerable<InvoiceItem> GetAllInvoiceItems()
        {
            return _invoiceItemService.GetAllInvoiceItems();
        }

        
        [HttpGet("{id}")]
        public ActionResult<InvoiceItem> GetInvoiceItemById(int id)
        {
            var invoiceItem = _invoiceItemService.GetInvoiceItemById(id);
            if (invoiceItem == null)
            {
                return NotFound();
            }
            return invoiceItem;
        }

        
        [HttpPost]
        public ActionResult<InvoiceItem> CreateInvoiceItem([FromBody] InvoiceItem invoiceItem)
        {
            _invoiceItemService.AddInvoiceItem(invoiceItem);
            return CreatedAtAction(nameof(GetInvoiceItemById), new { id = invoiceItem.Id }, invoiceItem);
        }

    
        [HttpPut("{id}")]
        public IActionResult UpdateInvoiceItem(int id, [FromBody] InvoiceItem invoiceItem)
        {
            if (id != invoiceItem.Id)
            {
                return BadRequest();
            }

            try
            {
                _invoiceItemService.UpdateInvoiceItem(invoiceItem);
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }

       
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoiceItem(int id)
        {
            var invoiceItem = _invoiceItemService.GetInvoiceItemById(id);
            if (invoiceItem == null)
            {
                return NotFound();
            }

            _invoiceItemService.DeleteInvoiceItem(id);
            return NoContent();
        }

    }

}


