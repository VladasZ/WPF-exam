using ERP_system.ClassesExtensions;
using ERP_system.Database.Entities;
using RandomUserGenerator;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system.Database
{
    public class ERPDbContext : DbContext
    {
        public ERPDbContext() 
            : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ERP2;Integrated Security=True")
        {
            foreach (Employee emp in Employees)
                emp.Photo = emp.PhotoData.toImage();
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
