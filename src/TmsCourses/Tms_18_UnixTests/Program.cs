using Core;
using System;

namespace Tms_18_UnixTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Название - [тестируемый метод] [сценарий] [ожидаемое поведение]
            // Стиль ARRANGE(данные для входа), ACT(действие), ASSERT(проверка и взаимодействие)
            // тестируется одна вещь за один раз
            // Stabs (попытка) и mock (пародировать)

            Calc calc = new Calc();

            var summ = calc.Add(1, 2);

            Console.WriteLine(summ);

            // 1. Создали проект Untest
            // 2. Сделали ссылку на проект
            // 3. Написали наш патерн  ARRANGE, ACT, ASSERT

            Console.ReadLine();
        }
    }
}
