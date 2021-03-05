using System;
using System.Linq;

namespace CodeBlog_25_AttributeAndReflecsion
{
    class Program
    {
        static void Main(string[] args)
        {
            // атрибутами являются наследники базового класса
            // очередной вспомогательный класс
            // типа помтка, к которой мы можем потом обратиться


            var photo1 = new Photo("Maldives.png")
            {
                Path = "D:\\Games\\Maldives.png"
            };
            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string ('_', 35));
            var photo2 = new Photo("Bali.png")
            {
                Path = "D:\\Games\\Maldives.png"
            };
            var type2 = typeof(Photo);
            var attributes2 = type.GetCustomAttributes(false); //возвращает атрибьюты
            foreach (var item in attributes2)
            {
                Console.WriteLine(item);
            }

            var properties = type2.GetProperties();
            foreach (var item in properties)
            {
                var attr = item.GetCustomAttributes(false);

                if (attr.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(item.PropertyType + " " + item.Name + " " + item.Attributes);
                }
                
                //foreach (var a in attr)
                //{
                //    Console.WriteLine(a);
                //}
            }
            
            Console.ReadLine();
        }
    }
}
