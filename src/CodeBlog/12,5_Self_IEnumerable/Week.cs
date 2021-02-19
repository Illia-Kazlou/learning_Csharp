using System.Collections;

namespace _12_5_Self_IEnumerable
{
    //класс Week, который представляет неделю и хранит все дни недели, реализует интерфейс IEnumerable
    public class Week : IEnumerable
    {
        //массив дней
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

        //вместо реализации IEnumerator мы просто возвращаем в методе GetEnumerator объект IEnumerator для массива
        public IEnumerator GetEnumerator()
        {
            //return days.GetEnumerator();
            return new WeekEnumerator(days);
        }
        //Благодаря этому мы можем перебрать все дни недели в цикле foreach.
    }
}
