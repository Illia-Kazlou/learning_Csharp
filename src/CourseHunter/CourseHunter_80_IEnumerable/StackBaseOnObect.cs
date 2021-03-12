using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CourseHunter_80_IEnumerable
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

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(_item);
        }

        // явная имплементация интерфейса.
        // этот метод мы не будем видеть при создании экземпляра класса.
        IEnumerator IEnumerable.GetEnumerator() // необобщенный. но мы его тоже можем вызвать иезуитским способом, смотри Program.cs.
        {
            // А здесь можно вызвать реализацию Generiково
            return GetEnumerator();
        }
        // с помощи явной реализации интерфейса мы ее скрываем от внешнего пользователя.
    }

    // нам нужен экземпляр класса который реализует IEnumerator
    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private int position = -1;

        public StackEnumerator(T[] array)
        {
            this.array = array;
        }

        public T Current
        {
            get
            {
                return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() // в 99% случаев он ничего не делает. Утилизировать(Удалить из памяти)
        {
        }

        public bool MoveNext()
        {
            position++;
            return position < array.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
