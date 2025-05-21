using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Inventory.API.Models
{
    [Table("products")]
    public class Product
    
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("sku")]
        public string Sku { get; set; } = "";

        [Column("product_name")]
        public string ProductName { get; set; } = "";

        [Column("brand_id")]
        public string BrandId { get; set; } = "";

        [Column("category_id")]
        public string CategoryId { get; set; } = "";

        [Column("order_date")]
        public string OrderDate { get; set; } = "";

        [Column("arrival_date")]
        public string ArrivalDate { get; set; } = "";

        [Column("expiry_date")]
        public string ExpiryDate { get; set; } = "";

        [Column("quantity_in_stock")]
        public string QuantityInStock { get; set; } = "";

        [Column("cost_price")]
        public string CostPrice { get; set; } = "";

        [Column("srp_price")]
        public string SrpPrice { get; set; } = "";

        [Column("wholesale_price")]
        public string WholesalePrice { get; set; } = "";

        [Column("description")]
        public string Description { get; set; } = "";

        [Column("is_active")]
        public string IsActive { get; set; } = "";

        [Column("created_at")]
        public string CreatedAt { get; set; } = "";

        [Column("updated_at")]
        public string UpdatedAt { get; set; } = "";
    }
}
