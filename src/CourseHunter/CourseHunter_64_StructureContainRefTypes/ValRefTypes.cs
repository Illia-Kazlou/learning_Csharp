using System;

namespace CourseHunter_64_StructureContainRefTypes
{
    public struct EvilStruct
    {
        public int X;
        public int Y;

        public PointRef PointRef;
    }

    // Это структура
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
