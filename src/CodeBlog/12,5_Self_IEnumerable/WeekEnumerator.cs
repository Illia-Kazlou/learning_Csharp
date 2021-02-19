using System;
using System.Collections;

namespace _12_5_Self_IEnumerable
{
    //WeekEnumerator, который реализует IEnumerator
    public class WeekEnumerator : IEnumerator
    {
        string[] days;
        //для хранения текущей позиции определена переменная position, (в исходном состоянии) указатель должен указывать на позицию условно перед первым элементом.
        int position = -1;

        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }

        //Указатель должен указывать на позицию условно перед первым элементомю.
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }


    }
}
