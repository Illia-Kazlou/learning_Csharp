using System;
using System.Collections.Generic;
using System.Text;

namespace _9._5_CLRviaCSharp_Property_Indexators
{
    public sealed class BitArray
    {
        private byte[] byteArray;
        private int numBits;

        public BitArray(int numBits)
        {
            if (numBits <= 0)
            {
                throw new ArgumentNullException(nameof(numBits), "Количиство битов в байте не должно быть меньше либо равным 0");
            }

            this.numBits = numBits;

            byteArray = new byte[(numBits + 7) / 8];
        }

        public bool this [int bitPosition]
        {
            get
            {
                if ((bitPosition < 0) || (bitPosition >=numBits))
                {
                    throw new ArgumentOutOfRangeException(nameof(bitPosition), "Позиция не может быть меньше нуля и ");
                };
                return (byteArray[bitPosition / 8] & (1 << (bitPosition % 8))) != 0;
            }
        }
    }
}
