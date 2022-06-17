using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBRBL.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DoorNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }
}
