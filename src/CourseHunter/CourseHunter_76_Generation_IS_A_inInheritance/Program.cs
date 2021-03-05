using System;

namespace CourseHunter_76_Generation_IS_A_inInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rect { Height = 6, Width = 12 };
            IShape square = new Square { SizeC = 6 };

            Console.WriteLine(rect.CalcSquare());
            Console.WriteLine(square.CalcSquare());

            //Rect rect = new Rect { Height = 6, Width = 12 };  //option inisiolazer
            //int rectArea = AreaCalculator.CalcSquare(rect);
            //Console.WriteLine($"Rect area = {rectArea}");

            //Rect squre = new Square { Height = 6, Width = 12 }; //Representative по сути это не квадрат а экземпляр прямоугольника тип квадрат.
            //int squareArea = AreaCalculator.CalcSquare(squre);
            //Console.WriteLine($"Rect area = {squareArea}");

            Console.ReadLine();
        }
    }
}
