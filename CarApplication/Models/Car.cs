namespace CarApplication.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public string? Color { get; set; }
        public string GearType { get; set; }

        public Brand? Brand { get; set; }
    }

}
