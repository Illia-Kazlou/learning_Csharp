using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_68_BoxingUnboxing
{
    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"x = {X}, e = {Y}");
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"x = {X}, e = {Y}");
        }
    }
}
