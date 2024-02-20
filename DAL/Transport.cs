namespace DAL
{
    public class Transport
    {
        public Guid TransportId { get; set; }
        public int TransportType { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string RegistrationPlate { get; set; }

        public virtual Person? Person { get; set; }

    }
}
