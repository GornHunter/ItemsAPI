using System.ComponentModel.DataAnnotations;

namespace TestAPI.DTOs
{
    public class UpdateItemDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000)]
        public decimal Price { get; set; }
    }
}
