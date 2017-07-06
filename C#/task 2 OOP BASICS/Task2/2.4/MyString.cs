using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class MyString
    {
        public void SetText(string value)
         {
              this.stroka = value.ToCharArray(); 
         }

        char[] stroka;
        
        public char[] GetText()
        {
            return stroka;
        }
        
    }
}
