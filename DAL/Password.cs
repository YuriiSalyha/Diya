using System.Reflection.Metadata;

namespace DAL
{
    public class Password
    {
        public Guid PasswordId { get; set; }
        public Guid PersonId { get; set; }

        public virtual Person? Person { get; set; }


        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
