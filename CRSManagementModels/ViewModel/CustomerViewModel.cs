namespace CRSManagementModels.ViewModel
{
    public class CustomerViewModel
    {
        public int Id {get;set;}
        public DateTime Date {get;set;}
        public string Description { get; set; }
        public string Address{ get; set; }
        public string City{ get; set; }
        public string State{ get; set; }
        public string ZipCode{ get; set; }
        public int RegisteredBy{ get; set; }
        public string Contact{ get; set; }
        public string PhoneNumber{ get; set; }
        public string EmailAddress{ get; set; }
    }
}
