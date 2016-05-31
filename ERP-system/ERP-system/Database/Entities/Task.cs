using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system.Database.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PercentDone { get; set; }
        public Employee Performer { get; set; }

        public override string ToString()
        {
            return Name + " " + PercentDone + "%";
        }
    }
}
