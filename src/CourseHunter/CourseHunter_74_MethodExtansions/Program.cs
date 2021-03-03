using System;
using System.Collections.Generic;

namespace CourseHunter_74_MethodExtansions
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<object> listInt = new List<object> { 1, 2, 3 };

            IBaseCollection baseCollection = new BaseList(4);

            baseCollection.AddRange(listInt);

            baseCollection.Add(1);

            Console.ReadLine();
        }
    }
}
