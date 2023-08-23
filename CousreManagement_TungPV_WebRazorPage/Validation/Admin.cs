using ASP.NETCoreWebApp.Binding;
using System.Text.Json;

namespace ASP.NETCoreWebApp.Validation
{
    public class Admin
    {
        public AccountAdmin getAdminAccount()
        {
            AccountAdmin admin = new AccountAdmin();
            string filename = "AccountAdmin.json";
            string json = File.ReadAllText(filename);

            admin = JsonSerializer.Deserialize<AccountAdmin>(json); 
                return admin;

        }
    }
}
