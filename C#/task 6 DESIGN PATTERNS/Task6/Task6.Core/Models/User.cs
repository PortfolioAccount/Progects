using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Core
{
    public class User
    {
        public User()
        {
            Awards = new List<Award>();
        }
        
        public int Id { get; set; }
        
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDay.Year;
                if (now < BirthDay.AddYears(age)) age--;
                return age;
            }
        }

        public List<Award> Awards { get; set; }
    }
}
