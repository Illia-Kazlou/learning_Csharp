using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_OCPrinciple.Specification
{
    internal class SizeSpecification : BaseSpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public override bool IsSatisfied(Product item)
        {
            return item.Size == size;
        }
    }
}
