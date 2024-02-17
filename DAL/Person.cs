using Azure;
using System;
using System.Data.SqlTypes;

namespace DAL
{
    public class Person
    {
        public Guid PersonId { get; set; } // Added 'public' access modifier
        public string Login { get; set; }

        public virtual List<RealEstate> RealEstates { get; set; } = new();
        public virtual List<Transport> Transports { get; set; } = new();
        public virtual List<Document> Documents { get; set; } = new();
        public virtual TaxPayerCard? TaxPayerCard { get; set; }
        public virtual Password? Password { get; set; }
    }
}
