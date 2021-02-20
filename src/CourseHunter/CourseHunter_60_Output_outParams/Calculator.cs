using System;

namespace CourseHunter_60_Output_outParams
{
    public class Calculator
    {
        public bool TryDivide(double divisible, double divisor, out double result) //out параметр должен идти в конце, может быть больше одного.
        {
            result = 0;

            if (divisor == 0)
            {
                return false;
            }
            else
            {
                result = divisible / divisor;
                return true;
            }
        }

        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, double sizeSideCA)
        {
            //Semiperimeter
            double semiperimeter = (sizeSideAB + sizeSideBC + sizeSideCA) / 2;

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
        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, int alpfa, bool IsRadians = false)
        {
            double rads = alpfa * Math.PI * 180;
            return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(rads);
        }
    }
}
