namespace DAL
{
    public class RealEstate
    {
        public Guid RealEstateId { get; set; }
        public int? Size { get; set; }
        public string? Street { get; set; }
        public virtual List<Person> People { get; } = new();

    }

}
