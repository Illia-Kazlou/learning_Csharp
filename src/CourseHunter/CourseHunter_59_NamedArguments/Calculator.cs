using System;

namespace CourseHunter_59_NamedArguments
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

        /// <summary>
        /// Area of tringle.
        /// </summary>
        /// <param name="sizeSideAB">Size of side AB.</param>
        /// <param name="sizeSideBC">Size of side BC.</param>
        /// <param name="alpfa">Angle between side AB and BC.</param>
        /// <param name="IsRadians">Type of angle.</param>
        /// <returns></returns>
        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, int alpfa, bool IsRadians = false )
        {
            double rads = alpfa * Math.PI * 180;
            return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(rads);
        }
    }
}
