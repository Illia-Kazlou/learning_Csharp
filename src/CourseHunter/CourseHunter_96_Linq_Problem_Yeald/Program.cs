using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseHunter_96_Linq_Problem_Yeald
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };

            var qwery = list.Where(x => x >= 2); //  так как этот запрос построен на foreach  и yeald  он немедленно не выполняется. Он конструируется. 
            // ЕСЛИ В КОНЦЕ СДЕЛАТЬ TOLIST() то запрос будет сразу сделан!!!!!!!!!!!!!!!!
            // Таким оброзом в Linq операторах можно выделить следующую категороию операторов. ОТЛОЖЕННЫЕ(DEFERRED) и ЖАДНЫЕ(GREEDY).

            // ОЛОЖЕННЫЕ не выполняются а конструируются. такие как SELECT, TAKE, SKIP, WHERE and etc.
            // ЖАДНЫЕ - COUNT, AVERAGE, MIN, MAX, SOME, FIRST, LAST, TOLIST, TOARRAY and etc.

            list.Remove(3); // отложенный оператор.

            foreach (var item in qwery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string ('-', 40));

            Console.WriteLine(qwery.Count()); // по идее должен быть вывод 2. но вывод будет 1.
            // Пока мы не запустим foreach (в нашем лучае COUNT) или не запуситли GREEDY оператор отложенный запрос выполнен  не будет


            Console.ReadLine();
        }
    }
}
