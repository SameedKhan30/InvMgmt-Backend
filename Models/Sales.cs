using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvMgmt.Models
{
    public class Sales
    {

        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    }
}
