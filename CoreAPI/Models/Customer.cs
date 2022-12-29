using System.Net;

namespace CoreAPI.Models
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string idNumber { get; set; }
        public Address address { get; set; }
        public IEnumerable<Contract> contractList { get; set; }

    }
}
