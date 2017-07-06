using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] mas2 = { 1.1, 1.2, 1.3, 1.4, 1.5 };
            double[] mas3 = { 12, 11.5, 3 };

 
            double rez = mas1.Sum() + mas2.Sum() + mas3.Sum();
            Console.WriteLine($"Суммма всех элементов всех массивов равна {rez}!");
            Console.ReadKey();
            
        }
    }
}
