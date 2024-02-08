namespace TodoAdvWeb.Server.Models
{
    public class CustomerAddress
    {
        public int CustomerAddressID { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }

        // more information
        public bool IsCurrent { get; set; }
    }
}
