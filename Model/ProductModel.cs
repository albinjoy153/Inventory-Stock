using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryProject.Model
{
    [Table("Product")]
    public class ProductModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductCode { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }

        public byte[] ProductImage { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedDate { get; set; } = DateTimeOffset.UtcNow;
        public string CreatedUser { get; set; }
        public bool IsFavourite { get; set; }
        public bool Active { get; set; }

        [Required(ErrorMessage = "HSN Code is required")]
        public string HSNCode { get; set; }
        public decimal TotalStock { get; set; }
       
    }
   
}
