using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_reader
{
    class Dan
    {
        public string Hомер { get; private set; }
        public string Марка { get; private set; }
        public string Цвет { get; private set; }
        public string Владелец { get; private set; }
        public Dan(string name,string mark, string col, string vl)
        {
            Hомер = name;
            Марка =mark;
            Цвет=col;
            Владелец = vl;
        }

        public override string ToString()
        {
            return Hомер;
        }
    }
}
