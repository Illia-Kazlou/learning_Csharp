namespace _12_Self_Generic
{
    public class Bacallies<T, TT> : Product<T, TT>
    {
        public Bacallies(string name, T volume, TT energy) : base(name, volume, energy)
        {

        }
    }
}
