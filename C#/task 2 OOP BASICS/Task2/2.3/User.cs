using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    public class User
    {
        private string name;
        private string surname;
        private string patronymic;
        public DateTime date;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
      

        public DateTime SetBirthDate(int day, int mounth, int years)
        {
            return date = new DateTime(years, mounth, day);
        }

		// в названии метода не Set, а Get.
        public int SetAge()
        {
            if (DateTime.Now.Month >= date.Month)
                return DateTime.Now.Year - date.Year;
            else return DateTime.Now.Year - date.Year - 1;
        }
        




    }
}
