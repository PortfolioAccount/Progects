using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taska2;

namespace _2._6
{
    class Ring : Round
    {
        private double innerRadius;

		 
		public double InnerRadius
        {
            get
            {
                return innerRadius;
            }

            set
            {
                if (value > 0)
                {
                    innerRadius = value;
                }
                else
                {
                    throw new ArgumentException("Радиус окружности не может быть отрицательным или равным нулю!");
                }
            }

        }

        public double GetLenghtRad()
        {
            return (2 * Math.PI * innerRadius);
        }

        public double GetLenghtSum()
        {
            return (2 * Math.PI * innerRadius) + GetLenght();
        }


        public double GetAreaRad()
        {
            return Math.PI * Math.Pow(innerRadius, 2);
        }
    }
}
