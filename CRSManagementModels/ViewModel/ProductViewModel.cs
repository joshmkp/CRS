namespace CRSManagementModels.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public DateTime Date {get;set;}
        public int Quantity {get;set;}
        public string Description { get; set; }
        public decimal UnitPrice{ get; set; }
        public decimal TotalPrice { get; set; }
        public string InvoiceNumber { get; set; }
        public int SupplierId { get; set; }
        public bool Paid { get; set; }
        public DateTime PaidOn { get; set; }
        public decimal LastPrice { get; set; }

        public decimal SellPrice { get; set; }
        public DateTime LastBoughtOn { get; set; }
    }
}
