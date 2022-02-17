
namespace February16
{
    class Shoes
    {
        public int Id { get; set; }
        public string? ShoesName { get; set; }

        public int ShoesCount { get; set; }

        public int? HasDelivery { get; set; }
        public Delivery? Delivery { get; set; }
    }
}
