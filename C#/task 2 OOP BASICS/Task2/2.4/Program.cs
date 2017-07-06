using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString();
            str.SetText("sdsdsa");
         
            char[] str2 = str.GetText();
                for (int i = 0; i < str2.Length; i++)
                   Console.Write(str2[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
