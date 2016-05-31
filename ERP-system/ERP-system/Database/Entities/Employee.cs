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

        public int TeamWorkEfficiency { get; set; }
        public int Punctuality { get; set; }
        public int WorkQuality { get; set; }
        public int SomeAnotherQuality { get; set; }
        public List<Task> Tasks { get; set; }

        [NotMapped]
        public Image Photo { get; set; }
        public string ImageURL { get; set; }
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
                PhotoData = user.Photo.toByteArray(),
                ImageURL = user.PhotoURL,
                Punctuality = StaticExtensions.rand.Next(0, 100),
                TeamWorkEfficiency = StaticExtensions.rand.Next(0, 100),
                WorkQuality = StaticExtensions.rand.Next(0, 100),
                SomeAnotherQuality = StaticExtensions.rand.Next(0, 100),   
            };

            List<Task> taskList = new List<Task>();

            for (int i = StaticExtensions.rand.Next(3, 10); i > 0; i--)
            {
                taskList.Add(new Task()
                {
                    Name = StaticExtensions.RandomString(),
                    PercentDone = StaticExtensions.rand.Next(0, 100),
                    Performer = newEmployee
                });
            }

            newEmployee.Tasks = taskList;

            return newEmployee;
        }

    }
}
