using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RandomUserGenerator
{
    public static class DataSource
    {
        public static List<User> getRandomUsers(int Quantity)
        {
            string data = downloadURL("http://api.randomuser.me/?results=" + Quantity + "&nat=us,gb");

            Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(data);

            List<User> users = new List<User>();

            foreach (Result result in rootobject.results)
            {
                User newUser = new User()
                {
                    FirstName = result.name.first,
                    LastName = result.name.last,
                    Sex = result.gender == "male" ? true : false,
                    Address = result.location.city + " " + result.location.street,
                    Email = result.email,
                    Phone = result.cell,
                    Photo = imageFromURL(result.picture.large)
                };

                users.Add(newUser);
            }

            return users;
        }

        public static string downloadURL(string URL)
        {
            string data;

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                data = client.DownloadString(URL);
            }

            return data;
        }

        public static Image imageFromURL(string URL)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(URL);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
