using ERP_system.ClassesExtensions;
using RandomUserGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_system.Database.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        [NotMapped]
        public Image Photo { get; set; }
        public byte[] PhotoData { get; set; }

        public static Employee fromUser(User user)
        {
            Employee newEmployee = new Employee()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                BirthDate = StaticExtensions.RandomDate(),
                Address = user.Address,
                Email = user.Email,
                Phone = user.Phone,
                Sex = user.Sex,
                Photo = user.Photo,
                PhotoData = user.Photo.toByteArray()
            };

            return null;
        }

    }
}
