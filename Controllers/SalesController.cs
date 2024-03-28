using InvMgmt.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly DbInventoryContext _context;

        public SalesController(DbInventoryContext context)
        {
            _context = context;
        }

        // POST: api/Sales
        [HttpPost]
        public async Task<ActionResult<Sales>> CreateSale(Sales sale)
        {
            if (sale == null || sale.ProductID <= 0 || sale.Quantity <= 0)
            {
                return BadRequest("Invalid sale data.");
            }

            var product = await _context.Products.FindAsync(sale.ProductID);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            if (product.Quantity < sale.Quantity)
            {
                return BadRequest("Insufficient product quantity for sale.");
            }

            product.Quantity -= sale.Quantity;
            _context.Products.Update(product);

            sale.SaleDate = DateTime.UtcNow;
         //   _context.Sales.Add(sale);

            await _context.SaveChangesAsync();

            return CreatedAtRoute("GetSale", new { id = sale.SaleID }, sale);
        }
    }
}
