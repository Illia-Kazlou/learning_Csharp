using System;
using System.Reflection;

namespace ITVDN_Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            Console.WriteLine(race.Armor);
            Console.WriteLine(new string ('_', 35));

            //race.armor = "Hello"; // не получится так как Armor нет сеттера только геттер.
            // Чтобы достучаться до этого поля нам необходимо преминить РЕФЛЕКСИЮ.

            // Любая работа с пефлексией начинается с получение экземпляра класса TYPE для нашего типа
            // с которым мы хотим работать.

            // Поэтому.
            // Получаем тип.
            var type = race.GetType();

            // Далее чтобы обратиться к скрытым полям и свойсвам.
            // здесь мы во флагах указываем что это экземплярное поле и оно не открыто.
            var field = type.GetField("armor", BindingFlags.Instance | BindingFlags.NonPublic);

            field.SetValue(race, "46 попугаев защиты");

            Console.WriteLine(race.Armor);
            // Но по сути его так никто не использует.
            //--------------------------------------------------------------------------------
            
            //Достал тип объекта -> его свойства -> вывел на экран

            Console.WriteLine(new string ('_', 35));

            var now = DateTime.Now;

            type = now.GetType();

            var properies = type.GetProperties();

            foreach (var item in properies)
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(now)}");
            }


            Console.ReadLine();
        }
    }
}
