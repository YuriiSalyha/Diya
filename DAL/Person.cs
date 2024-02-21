namespace DAL
{
    public class Person
    {
        public Guid PersonId { get; set; } 
        public string Login { get; set; }

        public virtual List<RealEstate> RealEstates { get; } = new(); // many to many

        public virtual List<Transport> Transports { get; set; } = new(); // one to many
        public virtual List<Document> Documents { get; set; } = new(); // one to many
        public virtual List<TaxPayerCard> TaxPayerCard { get; set; } = new(); // one to many
        public virtual List<Password> Password { get; set; } = new(); // one to many
    }
}
