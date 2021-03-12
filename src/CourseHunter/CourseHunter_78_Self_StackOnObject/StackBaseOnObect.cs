using System;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_78_Self_StackOnObject
{
    public class StackBaseOnObect
    {
        private object[] _item;

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
            _item = new object[defaulfCapasity];
        }

        public StackBaseOnObect(int capasity)
        {
            _item = new object[capasity];
        }

        public void Push (object item)
        {
            if (_item.Length == Count)
            {
                object[] largerArray = new object[Count * 2];
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
            _item[--Count] = null;
        }

        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _item[Count - 1];
        }

    }
}
