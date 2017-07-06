
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static int[] Func(int[] mas)
        {
            var query = from item in mas
                        orderby item
                        select item;
            return query.ToArray();

        }
        static void Main(string[] args)
        {
            int[] mas = { 3, 5, 8, 3, 55, 786, 23, 79, 4, 56747, 1 };


            mas = Func(mas);

            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
