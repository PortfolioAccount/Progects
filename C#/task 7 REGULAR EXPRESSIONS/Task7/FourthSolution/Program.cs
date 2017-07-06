using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FourthSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string text = Console.ReadLine();
            var regex1 = new Regex(@"(^| )((|-)(([1-9]\d+\.\d+)|([0-9]\.\d+)|([1-9]\d+)|([0-9])))($| )"); //(^| )(|-)(([1-9]\d+)|([0-9]))(|((|\.)(([1-9]\d+)|[0-9])))($| )
            var regex2 = new Regex(@"(^| )((-|)([1-9](\d+)(|(.\d+))e(-|)([1-9]|[1-9]\d+)))($| )");
            var match1 = regex1.Match(text);
            var match2 = regex2.Match(text);
            if (match2.Success)
            { Console.WriteLine($"Введенное вами число: {text} в научной нотации!"); Console.ReadKey(); return; }
            if (match1.Success)
            { Console.WriteLine($"Введенное вами число: {text} в обычной нотации!"); Console.ReadKey(); return; }
            Console.WriteLine("Вы ввели не число!");
            Console.ReadKey();
        }
    }
}
