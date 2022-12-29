namespace CoreAPI.Models
{
    public class Contract
    {
        public string contractId { get; set; }
        public string contractName { get; set; }
        public IEnumerable<Package> packagesList { get; set; }
    }
}