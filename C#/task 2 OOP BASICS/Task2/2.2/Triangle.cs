using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Triangle
    {
        private double a;
        private double b;
        private double c; 

        public void Prov(double storA, double storB, double storC)
        {
            if ((storA <= 0) || (storB <= 0) || (storC <= 0) || ((storA + storB) <= storC) || ((storA + storC) <= storB) || ((storB + storC) <= storA))
            {
                throw new ArgumentException("У вас есть одна или несколько отрицательных или равных нулю сторон треугольника или же сумма двух сторон треугольника меньше третьей!");
            }
            a = storA;
            b = storB;
            c = storC;
        }
        

        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Perimetr()
        {
            return a + b + c;
        }
    }
}
