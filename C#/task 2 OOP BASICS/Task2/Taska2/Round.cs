using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taska2
{
    public class Round
    {
        private double radius;
        private int x;
        private int y;

        public double Radius
        {
            get
            {
                return radius;
            }

            set 
             {
                 if (value > 0)
                     {
                        radius = value;
                     }
                 else
                     {
                         throw new ArgumentException("Радиус окружности не может быть отрицательным или равным нулю!");
                     }
             }
    }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetLenght()
        {
            return 2 * Math.PI * radius;
        }
    }
}
