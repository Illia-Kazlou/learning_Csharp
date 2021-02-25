using System;

namespace CourseHunter_68_BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            object boxing = x; //Процесс называется BOXING
            int y = (int)boxing; //Процесс Unboxing c явным приведением типа 

            double PI = 3.14;
            object obj1 = PI;

            int number = (int)(double)obj1; // Работать с object не безопасно из-за приведения типов
            Console.WriteLine(number);




            Console.ReadLine();
        }

        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef; //проверяем содержит ли object класс PointRef. 1 - ВАРИАНТ
            if (isPointRef)
            {
                PointRef pointRef = (PointRef)obj;
                pointRef.X = 5;
                pointRef.Y = 10;
            }

            PointRef pointRef1 = obj as PointRef;

            if (pointRef1 != null)
            {
                Console.WriteLine(pointRef1.X);
            }

        }
    }
}
