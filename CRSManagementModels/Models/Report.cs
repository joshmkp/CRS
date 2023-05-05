using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRSManagementModels.Models
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public User User { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal TotalAfterTax { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public decimal Tax { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidOn { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        public decimal Cost { get; set; }
        public decimal Profit { get; set; }

        

        
    }
}
