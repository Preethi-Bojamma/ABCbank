using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCbank.Models
{
    public class CustomerDetails
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string EmailId { get; set; }
            public string PhoneNo { get; set; }
            public DateTime DOB { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public int PinCode { get; set; }
            public string AadharNo { get; set; }
    }
    
}
