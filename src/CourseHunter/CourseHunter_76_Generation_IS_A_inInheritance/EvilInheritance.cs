using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_76_Generation_IS_A_inInheritance
{
    public class Rect : IShape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int CalcSquare()
        {
            return Height * Width;
        }
    }

    public class Square : IShape
    {
        public int SizeC { get; set; }

        public int CalcSquare()
        {
            return SizeC * SizeC;
        }
    }

    public static class AreaCalculator
    {
        //public static int CalcSquare(Square square)
        //{
        //    return square.Height * square.Height; 
        //}

        public static int CalcSquare(Rect rect)
        {
            return rect.Height * rect.Width;
        }
    }

    // как лучше было сделать.
    public interface IShape
    {
        int CalcSquare();
    }


}
