using System;

namespace CourseHunter_63_ValueReferenseTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PointVal pointVal = new PointVal();  //или  PointVal pointVal;
            pointVal.X = 10;
            pointVal.Y = 30;

            PointVal pointVal2 = pointVal;
            pointVal2.X = 15;
            pointVal2.Y = 35;

            pointVal.LogValues();
            pointVal2.LogValues();

            //структура хранит в себе определенное значение память выделяется.
            Console.WriteLine(new string('_', 40));

            PointRef pointRef = new PointRef();  //или  PointVal pointVal;
            pointRef.X = 10;
            pointRef.Y = 30;

            PointRef pointRef2 = pointRef;
            pointRef2.X = 15;
            pointRef2.Y = 35;

            pointRef.LogValues();
            pointRef2.LogValues();
            //Класс это ссылочный элемент в памяти хранится ссылка на объект.

            Console.ReadLine();
        }
    }
}
