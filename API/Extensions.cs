using TestAPI.DTOs;
using TestAPI.Models;

namespace TestAPI
{
    public static class Extensions
    {
        public static ItemDTO AsDTO(this Item item)
        {
            return new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreateDate = item.CreateDate
            };
        }
    }
}
