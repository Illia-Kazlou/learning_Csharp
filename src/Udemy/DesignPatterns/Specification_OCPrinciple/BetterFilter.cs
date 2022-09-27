using Specification_OCPrinciple.Interfaces;
using Specification_OCPrinciple.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_OCPrinciple
{
    internal class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, BaseSpecification<Product> specification)
        {
            foreach (var item in products)
            {
                if (specification.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
