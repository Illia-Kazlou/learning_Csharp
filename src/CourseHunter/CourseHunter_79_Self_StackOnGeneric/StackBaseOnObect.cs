using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_79_Self_StackOnGeneric
{
    public class StackBaseOnObect<T>
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

        public void Push (T item)
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

    }
}
