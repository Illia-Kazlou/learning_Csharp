using System;
using System.Collections;

namespace Metanit_IEnumerable
{
    /// <summary>
    /// Однако, возможно, потребуется задать свою собственную логику перебора объектов. Для этого реализуем интерфейс IEnumerator:
    /// </summary>
    public class WeekEnumerator : IEnumerator
    {
        private string[] week;
        private int curentDay = -1;

        public WeekEnumerator(string[] week)
        {
            this.week = week;
        }

        public object Current
        {
            get
            {
                //Cледует учитывать, что в самом начале (в исходном состоянии) указатель должен указывать на позицию условно перед первым элементом.
                return (curentDay <= -1 || curentDay >= week.Length) ? throw new InvalidOperationException() : week[curentDay];
            }
        }

        /// <summary>
        /// Ключевой момент при реализации перечислителя - перемещения указателя на элемент.
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            if (curentDay < week.Length - 1)
            {
                curentDay++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            curentDay = -1;
        }
    }
}
