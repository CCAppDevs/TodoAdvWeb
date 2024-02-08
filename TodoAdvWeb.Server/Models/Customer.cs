namespace TodoAdvWeb.Server.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        // navigation property
        public ICollection<ContactDetail> PhoneNumbers { get; set; }
        public List<CustomerAddress> Addresses { get; set; }

    }
}
