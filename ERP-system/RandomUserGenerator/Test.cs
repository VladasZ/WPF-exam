using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUserGenerator
{
    class Test
    {
        public static void Main(string[] args)
        {
            List<User> users = DataSource.getRandomUsers(50);

            foreach(User user in users)
                Console.WriteLine(user.FirstName + " " + user.Sex + " " + user.Email + " " + user.Address + "\n\n");
        }
    }
}
