using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseHunter_81_LazyEvaluationYield
{
    public class StackBaseOnObect<T> : IEnumerable<T>
    {
        private T[] _item;

        public int Count { get; private set; }  // счетчик элементов в массиве или в нашем случае стеке. 

        public int Capasity
        {
            get
            {
                return _item.Length;
            }
        }

        public StackBaseOnObect()
        {
            const int defaulfCapasity = 4;
            _item = new T[defaulfCapasity];
        }

        public StackBaseOnObect(int capasity)
        {
            _item = new T[capasity];
        }

        public void Push(T item)
        {
            if (_item.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_item, largerArray, Count);  // какой, куда, количество копируемых.

                _item = largerArray;
            }
            _item[Count] = item;
            Count++;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            _item[--Count] = default(T);  //null ------ здесь нельзя сказать какой тип  и не все типы поддерживают null.
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _item[Count - 1];
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new StackEnumerator<T>(_item);
        //}

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _item[i]; 
                // Эта реализация заменяет нижестоящий код.
                // Эта конструкция не производит полный прогон и вычисление.
                // Вызывается один раз, второй, третий.
                // Так называемое ленивое вычисление.
                // И большинство опреаций LINQ базируется на yield return.
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
//    public class StackEnumerator<T> : IEnumerator<T>
//    {
//        private readonly T[] array;
//        private int position = -1;

//        public StackEnumerator(T[] array)
//        {
//            this.array = array;
//        }

//        public T Current
//        {
//            get
//            {
//                return array[position];
//            }
//        }

//        object IEnumerator.Current
//        {
//            get
//            {
//                return Current;
//            }
//        }

//        public void Dispose() // в 99% случаев он ничего не делает. Утилизировать(Удалить из памяти)
//        {
//        }

//        public bool MoveNext()
//        {
//            position++;
//            return position < array.Length;
//        }

//        public void Reset()
//        {
//            position = -1;
//        }
//    }
//}
