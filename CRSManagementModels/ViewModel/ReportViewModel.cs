namespace CRSManagementModels.ViewModel
{
    public class ReportViewModel
    {
        public int Id {get;set;}
        public DateTime StartDate {get;set;}
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public int CreatedBy{ get; set; }
        public decimal TotalBeforeTax{ get; set; }
        public decimal TotalAfterTax{ get; set; }
        public int TypeId { get; set; }
        public decimal Tax { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidOn{ get; set; }
        public int CurrencyId{ get; set; }        
        public decimal Cost { get; set; }
        public decimal Profit { get; set; }
    }
}
