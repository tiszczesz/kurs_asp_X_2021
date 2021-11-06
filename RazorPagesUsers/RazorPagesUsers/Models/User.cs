using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RazorPagesUsers.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string AwatarName { get; set; } = "~/media/user.png";

        public string ToJSON() {
            return JsonSerializer.Serialize(this);
        }

        public static User FromJSON(string user) {
            User u = JsonSerializer.Deserialize<User>(user);
            return u;
        }
    }
}
