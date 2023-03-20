namespace TestAPI.DTOs
{
    public class ItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}
