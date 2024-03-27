using System;
using System.Collections.Generic;
using System.Text;

namespace salesCurd.MODELS
{
   
    public class Item
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public decimal ItemUprice { get; set; }
        public decimal ItemDiscountInPer { get; set; }
    }

   
    public class Invoice
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public string InvoiceCustomerName { get; set; }
        public string InvoiceCustomRemNo { get; set; }
        public string InvoicePaymentMode { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceAmountPaid { get; set; }
    }

   
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public int ItemCode { get; set; }
        public int ItemQty { get; set; }
        public decimal ItemUnitPrice { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal ItemAmount { get; set; }
    }

}
