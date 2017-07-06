using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш текст и программа определит, содержится ли в нем дата в формате dd-mm-yyyy");
            var regex = new Regex(@"(( |^)(([0-2]{1}[0-9]{1})|(3{1}[0,1]{1}))-((0{1}[1-9]{1})|(1{1}[0-2]{1}))-[0-9]+)( |$)");
            string text = Console.ReadLine();
            var match = regex.Match(text);
            if(match.Success)
            {
                Console.WriteLine($"В тексте \"{text}\": содержится дата!");
            }
            else
                Console.WriteLine($"В тексте \"{text}\": не содержится дата!");
            Console.ReadKey();
        }
    }
 //   <\w+>|<\W\w+>|
}
