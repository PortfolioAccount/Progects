using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FifthSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш текст и программа определит сколько раз в нем встречается время!");
            string text = Console.ReadLine();
            var regex = new Regex("(( |^)((([1][0-9])|([2][0-3])|([0-9])))):(([0-5])([0-9]))");
            var matches = regex.Matches(text);
            if (matches.Count == 0)
            { Console.WriteLine("В вашем тексте нет времени!"); }
            Console.WriteLine($"Количество встречаемого времени в вашем тексте равняется {matches.Count}!");
            Console.WriteLine("А именно:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
    
            Console.ReadKey();
        }
    }
}
