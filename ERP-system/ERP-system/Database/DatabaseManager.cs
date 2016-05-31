using ERP_system.Database.Entities;
using RandomUserGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system.Database
{
    public static class DatabaseManager
    {
        public static ERPDbContext DbContext { get; set; } = new ERPDbContext();

        

        public static void loadData()
        {
            if (DbContext.Employees.Count() != 0) return;

            List<User> users = DataSource.getRandomUsers(30);

            foreach (User user in users)
            {
                DbContext.Employees.Add(Employee.fromUser(user));
            }

            DbContext.SaveChanges();
        }

    }
}
