namespace DAL
{
    public class TaxPayerCard
    {
        public Guid TaxPayerCardId { get; set; }
        public string Number { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual Person? Person { get; set; }
    }
}
