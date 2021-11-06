using System.Collections.Generic;
using System.IO;

namespace RazorPagesUsers.Models {
    public class FileRepository {
        public static void SetConfigure(string fileName) {
            List<User> list = new List<User> {
                new User{Id = 1,Login = "user1",Password = "user1"},
                new User{Id = 2,Login = "user2",Password = "user2"},
                new User{Id = 3,Login = "user3",Password = "user3"},
                new User{Id = 4,Login = "user4",Password = "user4"},
                new User{Id = 5,Login = "user5",Password = "user5"}
            };
           
                FileRepository.JSONToFile(fileName,list);
           
        }
        public static void JSONToFile(string fileName, List<User> users) {
            
            using (var sw = new StreamWriter(fileName)) {
                foreach (var user in users) sw.WriteLine(user.ToJSON());
            }
        }
    }
}