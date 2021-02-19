using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_58_Params
{
    public class Calculator
    {
        public double Average (int[] numbers)
        {
            double summ = 0;
            foreach (var item in numbers)
            {
                summ += item;
            }

            return summ / numbers.Length;
        }

        public double Average2 (params int[] numbers)
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
