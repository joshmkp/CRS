using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRSManagementModels.Models
{
    public class Control
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string InvoiceNumber { get; set; }

        //public int UserId { get; set; }
                
        //public User User { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int TypeId { get; set; }

        public Type Type { get; set; }

        public int Tax { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalBeforeTax { get; set; }

        public decimal TotalAfterTax { get; set; }

        public bool Paid { get; set; }

        public DateTime? PaidOn { get; set; }

        public int? CurrencyId { get; set; }

        public Currency Currency { get; set; }

        public string Comments { get; set; }

        public decimal TotalCost { get; set; }

        public decimal Profit { get; set; }

        

        

        

        

        
    }
}
