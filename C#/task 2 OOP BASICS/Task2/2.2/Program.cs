using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static 
            void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            
                try
                {
                triangle.Prov(3, 4, 9);
                Console.WriteLine("Площадь треугольника равна " + triangle.Area());
                    Console.WriteLine("Периметр треугольника равен " + triangle.Perimetr());
                }
                catch (ArgumentException)
               {
                Console.WriteLine("Ошибка! У вас есть одна или несколько отрицательных или равных нулю сторон треугольника");
                Console.WriteLine(" или же сумма двух сторон треугольника меньше третьей!");
               }
                Console.ReadKey();
           
        }
    }
}
