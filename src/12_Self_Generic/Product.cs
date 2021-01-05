using System;

namespace _12_Self_Generic
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">"Т" это template - шаблон(ТАК ПРИНЯТО!) </typeparam>
    public partial class Product<T, TT>
    {
        /// <summary>
        /// Name of product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Valumee of product.
        /// </summary>
        public T Volume { get; set; }
        //TODO: Чтобы не создаввать такиеже как ниже.
        //public int Volume { get; set; }
        //public double Volume { get; set; }
        //public decimal Volume { get; set; }

        /// <summary>
        /// Energy of product
        /// </summary>
        public TT Energy { get; set; }
        //TODO: Чтобы не создаввать такиеже как ниже.
        //public int Energy { get; set; }
        //public double Energy { get; set; }
        //public decimal Energy { get; set; }

        public Product(string name, T volume, TT energy)
        {
            //TODO: Check argumens.
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            //if (energy < 0)
            //{
            //    throw new ArgumentException(nameof(energy));
            //}

            //if (volume <= 0)
            //{
            //    throw new ArgumentException(nameof(volume));
            //}

            Name = name;
            Volume = volume;
            Energy = energy;
        }
    }
}
