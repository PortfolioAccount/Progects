using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст, в котором мы заменим все HTML теги на знак \"_\"!");
            string substitution = "_";
            string text = Console.ReadLine();
            var regex = new Regex("<.*?>");
            var match = regex.Replace(text,substitution);
            Console.WriteLine(match);
            Console.ReadKey();
        }
    }
}
