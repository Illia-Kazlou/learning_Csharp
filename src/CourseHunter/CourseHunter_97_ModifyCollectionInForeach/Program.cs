using System;
using System.Collections.Generic;

namespace CourseHunter_98_ModifyCollectionInForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveInForeach();

            //RemoveInFor();

            //RemoveInForWromEnd();

            RemoveAllDemo();
            Console.ReadLine();
        }

        public static void RemoveInForeach()
        {
            List<int> list = new List<int> { 1, 2, 3, 43, 4, 5 };
            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    list.Remove(item); // Выскочит ошибка нельзя модифицировать лист внутри foreach.
                }

            }
            Console.WriteLine(list.Count);

            // По сути он роскладывается в следующий код.
            List<int>.Enumerator enumerator = list.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    int item = enumerator.Current;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                enumerator.Dispose();
            }
        }
        // Ок если foreach так защищен надо попробовать for.

        public static void RemoveInFor()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 56 };

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                //if (item % 2 == 0)
                //{
                //    list.Remove(item);
                //}
                // Это вроде работает.

                if (item <= 3)
                {
                    list.Remove(item);
                    --i; // Это можно назвать грязный хак.
                }
                // Но получается и так нельзя удалять элементы из листа.
                // Это происходит из-за смещения индексов.
                // В принципе мы это можем делать но отлько дикреминировав итератор
            }
            Console.WriteLine(list.Count);
        }
        // В принципе еще один вариант грязного удаления при помощи for может выглядеть следуще

        public static void RemoveInForWromEnd()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 45, 6 };
            for (int i = list.Count-1; i >= 0; i--)
            {
                var item = list[i];
                if (item <= 3)
                {
                    list.Remove(item);
                }
            }
            Console.WriteLine(list.Count);
            // Это более предпочтительный метод удаления из листа.
        }

        // Но есть еще способ

        public static void RemoveAllDemo()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 56 };
            list.RemoveAll(x => x <= 3); // это GREEDY оператор он выполняется сразу.

            Console.WriteLine(list.Count);
        }
    }
}
