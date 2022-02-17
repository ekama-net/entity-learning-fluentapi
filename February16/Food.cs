
namespace February16
{  
    class Food
    {
        public int Id { get; set; }
        public string? FoodName { get; set; }
        public int FoodCount { get; set; }

        public int? HasDelivery { get; set; }

        public Delivery? Delivery { get; set; }
    }
}
