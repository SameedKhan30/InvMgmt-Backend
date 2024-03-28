using System.ComponentModel.DataAnnotations.Schema;

namespace InvMgmt.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;
    }
}
