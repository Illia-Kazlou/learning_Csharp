using System;

namespace CourseHunter_67_NullReferenceExeption
{
    class Program
    {
        static void Main(string[] args)
        {
            PointVal? pv = null;
            //Console.WriteLine(pointVal2.X);    так мы не обратимся
            //Console.WriteLine(pointVal2.HasValue.X);    // так мы не обратимся, но
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }

            PointVal pv3 = pv.GetValueOrDefault();


            //Structure
            PointVal pointVal;
            //Console.WriteLine(pointVal.X); // когда объявляем структуру, она уже не NULL

            //Class
            PointRef c = null;
            //Console.WriteLine(c.X); //nullReferenceExeption

            Console.ReadLine();
        }
    }
}
