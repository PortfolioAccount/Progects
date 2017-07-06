using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            User man1 = new User();
            man1.Name = "Иван";
            man1.Surname = "Иванов";
            man1.Patronymic = "Иванович";
            man1.SetBirthDate(2, 1, 1991);
            Console.WriteLine(man1.Name + " " + man1.Surname + " " + man1.Patronymic + " " + man1.date + " года рождения "
                + man1.SetAge() + " лет!" );
            Console.ReadKey();
        }
    }
}
