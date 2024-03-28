namespace InvMgmt.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string AddressDetails {  get; set; }
        public string CustomerName { get; set; }
    }
}
