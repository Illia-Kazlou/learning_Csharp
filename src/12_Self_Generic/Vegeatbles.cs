namespace _12_Self_Generic
{
    public class Vegeatbles<T, TT> : Product<T, TT>
    {
        public Vegeatbles(string name, T volume, TT energy) :base(name, volume, energy)
        {

        }
    }
}
