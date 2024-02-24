
namespace Diia
{
    public class Config
    {
        // comment
        public bool login = false;
        public string username;
        public DateTime loginDate;

        public Config(bool login, string username, DateTime loginDate) 
        {
            this.login = login;
            this.username = username;
            this.loginDate = loginDate;
        }

        public Config() 
        {
            this.login = false;
        }
    }
}
