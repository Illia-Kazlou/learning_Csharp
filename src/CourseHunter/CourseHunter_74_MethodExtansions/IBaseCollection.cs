using System.Collections.Generic;

namespace CourseHunter_74_MethodExtansions
{
    public interface IBaseCollection
    {
        void Add(object obj);

        void Remove(object obj);

        //void Clear(object obj);
    }


    public static class BaseCallectionExtansion
    {
        public static void AddRange(this IBaseCollection baseCollection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                baseCollection.Add(item);
            }
        }
    }

    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int counter = 0;

        public BaseList( int initialCapasity)
        {
            items = new object[initialCapasity];
        }

        public void Add(object obj)
        {
            items[counter] = obj;
            counter++;
        }

        public void Clear(object obj)
        {
            items[counter] = null;
            counter--;
        }

        public void Remove(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
