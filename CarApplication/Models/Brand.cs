namespace CarApplication.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
    }

}
