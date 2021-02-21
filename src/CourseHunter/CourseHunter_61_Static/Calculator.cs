﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_61_Static
{
    public class Calculator
    {
        public static double CalcTriangleArea(double sizeSideAB, double sizeSideBC, double sizeSideCA)
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

        public double Average(int[] numbers)
        {
            double summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }

            return summ / numbers.Length;
        }

        public static double Average2(params int[] numbers)
        {

            double summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }

            return summ / numbers.Length;
        }
    }
}
