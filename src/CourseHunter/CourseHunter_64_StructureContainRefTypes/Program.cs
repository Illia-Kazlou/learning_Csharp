using System;

namespace CourseHunter_64_StructureContainRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            EvilStruct evilStruct = new EvilStruct();
            evilStruct.PointRef = new PointRef();

            evilStruct.X = 1;
            evilStruct.Y = 2;
            //либо
            evilStruct.PointRef = new PointRef() { X = 1, Y = 2};

            EvilStruct evilStruct2 = evilStruct;
            Console.WriteLine($" evilStruct x = {evilStruct.PointRef.X} y = {evilStruct.PointRef.Y}");
            Console.WriteLine($" evilStruct2 x = {evilStruct2.PointRef.X} y = {evilStruct2.PointRef.Y}");


            evilStruct2.PointRef.X = 42;
            evilStruct2.PointRef.Y = 45;

            Console.WriteLine($" evilStruct x = {evilStruct.PointRef.X} y = {evilStruct.PointRef.Y}");
            Console.WriteLine($" evilStruct2 x = {evilStruct2.PointRef.X} y = {evilStruct2.PointRef.Y}");



            Console.WriteLine(new string('_', 40));
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
