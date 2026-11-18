namespace Foodhub.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public double Rating { get; set; }
        public decimal DeliveryFee { get; set; }
        public int DeliveryMinutes { get; set; }
        public bool IsOpen { get; set; }
    }
}
