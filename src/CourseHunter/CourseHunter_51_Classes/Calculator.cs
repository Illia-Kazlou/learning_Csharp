using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_51_Classes
{
    public class Calculator
    {
        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, double sizeSideCA)
        {
            //Semiperimeter
            double semiperimeter = (sizeSideAB + sizeSideBC + sizeSideCA) / 2;

            //Area formula gerona
            //double square = Math.Sqrt(semiperimeter * (semiperimeter - sizeSideAB) * (semiperimeter - sizeSideBC) * (semiperimeter - sizeSideCA));
            //return square;
            //Не обязательно новая переменная.

            return Math.Sqrt(semiperimeter * (semiperimeter - sizeSideAB) * (semiperimeter - sizeSideBC) * (semiperimeter - sizeSideCA));
        }

        public double CalcTriangleArea(double sizeH, double sizeSemihypotenuse)
        {
            return ((sizeSemihypotenuse / 2) * sizeH);
        }

        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, int alpfa)
        {
            double rads = alpfa * Math.PI * 180; 
            return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(rads);
        }
    }
}
