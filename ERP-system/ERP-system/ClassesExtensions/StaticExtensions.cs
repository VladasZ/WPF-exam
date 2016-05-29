using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system.ClassesExtensions
{
    class StaticExtensions
    {
        public static Random rand = new Random();

        public static DateTime RandomDate()
        {
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
