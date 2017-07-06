using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static string[] SortMas(string[] mas)
        {
            var query = from item in mas
                        orderby item
                        orderby item.Count()
                        select item;
            return query.ToArray();
        }
        static void Main(string[] args)
        {
            string[] mas = {"ccccc", "bbbbb", "aaaaa", "cc", "zzzzzzzz", "aaaaaaaaaa", "q" };

            mas = SortMas(mas);

            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
