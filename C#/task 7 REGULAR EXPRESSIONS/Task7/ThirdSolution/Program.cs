using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThirdSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст содержащий адреса электронных почт!");
            string text = Console.ReadLine();
            var regex = new Regex(@"(| )(((\d|[a-zA-Z])(|(\d|\w|\.|-|_))+(\d|[a-zA-Z])@((\d|[a-zA-Z])(|(\d|\w|-))+(\d|[a-zA-Z])\.){1,6}([a-z]){2,6}))( |$)");
            var matches = regex.Matches(text);
            if (matches.Count == 0)
            {
                Console.WriteLine("В тексте нет адресов!"); Console.ReadKey(); return;
            }
     
            Console.WriteLine("\nВ тексте найдены следующие адреса: \n");
        
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            Console.ReadKey();
        }
    }
}
