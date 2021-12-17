using System.Collections;

namespace Metanit_IEnumerable
{
    /// <summary>
    /// 1. По сути новый класс Week представляет собой новую коллекцию
    /// </summary>
    public class Week //: IEnumerable
    {
        string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

        /// <summary>
        /// Достаточно в классе определить публичный метод GetEnumerator, который бы возвращал объект IEnumerator
        /// </summary>
        /// <returns>IEnumerator</returns>
        //public IEnumerator GetEnumerator()
        //{
        //    return week.GetEnumerator();
        //}

        /// <summary>
        /// Здесь теперь класс Week использует не встроенный перечислитель, а WeekEnumerator, который реализует IEnumerator.
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(week);
        }
    }
}
