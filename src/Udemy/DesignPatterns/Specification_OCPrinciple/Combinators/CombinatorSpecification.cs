using Specification_OCPrinciple.Specification;

namespace Specification_OCPrinciple.Combinators
{
    internal class CombinatorSpecification : BaseSpecification<Product>
    {
        private readonly BaseSpecification<Product> first, second;

        public CombinatorSpecification(BaseSpecification<Product> first, BaseSpecification<Product> second)
        {
            this.first = first;
            this.second = second;
        }

        public override bool IsSatisfied(Product item)
        {
            return first.IsSatisfied(item) && second.IsSatisfied(item);
        }
    }
}
