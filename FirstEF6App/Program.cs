using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEF6App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                //User user1 = new User { Name = "Tom", Age = 33};
                //User user2 = new User { Name = "Olivia", Age = 23 };
                //User user3 = new User { Name = "Alex", Age = 33 };
                //User user4 = new User { Name = "Morgan", Age = 42 };

                //db.Users.Add(user1);
                //db.Users.Add(user2);
                //db.Users.Add(user3);
                //db.Users.Add(user4);

                //db.SaveChanges();
                //Console.WriteLine("All users are successfully created.");

                //Console.WriteLine("List of users:");

                foreach (var user in db.Users)
                {
                    Console.WriteLine("{0}.{1} - {2}", user.Id, user.Name, user.Age);

                }
            }
            Console.Read();
        }
    }
}
