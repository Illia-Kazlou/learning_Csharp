using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_OCPrinciple.Specification
{
    internal class ColorSpecification : BaseSpecification<Product>
    {
        private readonly Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public override bool IsSatisfied(Product item)
        {
            return item.Color == color;
        }
    }
}
