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
    class ERPDbContext /*: DbContext*/
    {


        public DbSet<Employee> Employees { get; set; }

    }
}
