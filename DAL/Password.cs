namespace DAL
{
    public class Password
    {
        Guid PasswordId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual Person? Person { get; set; }
    }
}
