using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUserGenerator
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Image Photo { get; set; }
        public string PhotoURL { get; set; }
    }
}
