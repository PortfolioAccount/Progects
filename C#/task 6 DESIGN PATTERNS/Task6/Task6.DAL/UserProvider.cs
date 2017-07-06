using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Core;
using Task6.Core.Declaration;

namespace Task6.DAL
{
    public class UserProvider : IUserProvider

    {
        private List<User> users = new List<User>();
        private AwardProvider awardsProvider = new AwardProvider();
        

        //Здесь мы работаем с файлами. Считывание. Сохранение.
        public List<User> Get()
       {//в файл лезем один раз и сохраняем все данные в переменную.
            
            if (users.Count != 0)
            {
                return users;
            }

            using (FileStream file1 = new FileStream(Utilites.CheckFilePath("Users"), FileMode.Open))
            {
                StreamReader reader = new StreamReader(file1);
                string line = reader.ReadToEnd();
                string[] mas = line.Split('\n');
                foreach (var item in mas)
                {
                    if (string.IsNullOrWhiteSpace(item))
                    {
                        continue;
                    }

                    DateTime birthday;
                    int id;
                    string[] masUser = item.Split('|');
                    int[] masAward = string.IsNullOrEmpty(masUser[3]) || masUser[3] == "\r" ? new int[0] : masUser[3].Split(',').Select(p => int.Parse(p)).ToArray();
                 //   masAward = string.IsNullOrEmpty(masUser[3]) ? new int[0] : masUser[3].Split(',').Select(p => int.Parse(p)).ToArray();
                    users.Add(new User()
                    {
                        Id = int.TryParse(masUser[0], out id) ? id : 0,
                        Name = masUser[1],
                        BirthDay = DateTime.TryParse(masUser[2], out birthday) ? birthday : DateTime.Now,
                        Awards = awardsProvider.Get().Where( p => masAward.Any(q => p.Id == q)).ToList()
                    });
                }
            }
            return users;
          
            
        }

        public void Save(List<User> users)
        {//сохранить в файл и сохранить в локальную переменную users

            string spice = string.Empty;
         
                foreach (var item in users)
                {
                    string awards = string.Join(",", item.Awards.Select(p => p.Id));
                    spice +=(item.Id + "|" + item.Name + "|" + item.BirthDay + "|" + awards + Environment.NewLine);
                }

            File.WriteAllText(Utilites.CheckFilePath("Users"), spice);
            this.users = users;
        }
    }
}
