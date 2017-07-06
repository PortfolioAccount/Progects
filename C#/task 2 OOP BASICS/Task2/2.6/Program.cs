using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring ob = new Ring();
            ob.InnerRadius = 7;
            ob.Radius = 10;
            Console.WriteLine("Площадь всей окружности равна {0} !", ob.GetArea());
            Console.WriteLine("Площадь вписанной окружности равна {0} !", ob.GetAreaRad());
            Console.WriteLine("Длина описаного круга равна {0} !", ob.GetLenght());
            Console.WriteLine("Длина вписанного круга равна {0} !", ob.GetLenghtRad());
            Console.WriteLine("Сумма длин сторон описанного и вписанного круга равна {0} !", ob.GetLenghtSum());
            Console.ReadKey();
        }
    }
}
