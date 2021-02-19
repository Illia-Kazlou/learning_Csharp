using System;

namespace CourseHunter_23_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 3; // 0000 0011                                                                        1byte=8bit
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011                                           1int=4byte=32bit
            long l = i;// 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011   1long=bbyte=64bit

            float f = i; // 3.0

            b = (byte)i; // - явное приведение
            i = (int)f;  // - явное приведение для того чтобы избежать потери точности

            string str1 = "1";
            //i = (int)str; // так нельзя

            i = int.Parse(str1);

            int x = 5;
            int result = x / 2;

            double strResult = (double)x / 2;

            Console.WriteLine(strResult);
        }
    }
}
