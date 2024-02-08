namespace TodoAdvWeb.Server.Models
{
    public class ContactDetail
    {
        public int ContactDetailID { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }

        // navigation property
        public int CustomerID { get; set; }
    }
}
