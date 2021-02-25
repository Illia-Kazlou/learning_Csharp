namespace _12_Self_Generic
{
    public class Eating <T, TT>
        where T: Product <T, TT>
        where TT: Product<T, TT>

    {
        /// <summary>
        /// Connon proiperties.
        /// </summary>
        public int Volume { get; private set; }


        //public void Add(T product)
        //{
        //    Volume += (product.Volume) * product.Energy;
        //}
    }

}
