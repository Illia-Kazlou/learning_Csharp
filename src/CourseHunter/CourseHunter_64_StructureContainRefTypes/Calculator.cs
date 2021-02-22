using System;

namespace CourseHunter_64_StructureContainRefTypes
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
        //public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, int alphfa )
        //{
        //    double rads = alphfa * Math.PI * 180;
        //    return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(rads);
        //}

        //Что бы не плодить и не делать зло по повторению кода. 
        //По тому, что перегрузка это по сути копирование метода.
        //В большенсте случает bool IsRadians = false. Это и есть опциональный параметр.
        //ОГРАНИЧЕНИЯ: либо True or False или цифры.
        //Опциональные пораметрвы идут крайние в методе.
        public double CalcTriangleArea(double sizeSideAB, double sizeSideBC, int alphfa, bool IsRadians = false )
        {
            if (IsRadians)
            {
                Console.WriteLine("True");
                return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(alphfa);

            }
            else
            {
                double rads = alphfa * Math.PI * 180;
                return 0.5 * sizeSideAB * sizeSideBC * Math.Sin(rads); 
            }
        }
    }
}
