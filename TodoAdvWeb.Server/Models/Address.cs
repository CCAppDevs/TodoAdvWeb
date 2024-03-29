﻿namespace TodoAdvWeb.Server.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public List<CustomerAddress> CustomerAddresses { get; set; }
    }
}
