using Microsoft.AspNetCore.Mvc;
using ERP.Inventory.API.Models;
using ERP.Inventory.API.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ERP.Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly BaseService _baseService;

        public InventoryController(BaseService baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInventory()
        {
            // Predicate to fetch all products
            Expression<Func<Product, bool>> predicate = p => true;

            // Get list of products
            List<Product> products = await _baseService.ListOfTable(predicate);

            if (products == null || products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return NotFound("No products found.");
            }

            // Log products to console
            foreach (var product in products)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, Name: {product.ProductName}, SKU: {product.Sku}");
            }

            return Ok(products);
        }
    }
}
