using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round circle = new Round();
            try
            {
                circle.Radius = 3;
                Console.WriteLine("Площадь круга равна " + circle.GetArea());
                Console.WriteLine("Длина описанной окружности равна " + circle.GetLenght());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ошибка! Радиус не может быть отрицательным, либо равняться нулю!!!");
            }
 
            Console.ReadKey();
        }
    }
}
