
namespace February16
{
    class Delivery
    {
        public int DeliveryId { get; set; }
        public bool HasDelivery { get; set; }

        public List<Shoes> Shoes { get; set; }
        public List<Food> Foods { get; set; }
    }
}
