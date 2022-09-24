using System.Collections.Generic;

namespace MySelf_OperatorYield
{
    public class Product
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i;
            }
        }
    }
}
