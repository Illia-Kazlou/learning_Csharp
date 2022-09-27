using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_OCPrinciple.Specification
{
    internal abstract class BaseSpecification<T>
    {
        public abstract bool IsSatisfied(T item);
    }
}
