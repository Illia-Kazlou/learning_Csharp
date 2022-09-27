using Specification_OCPrinciple.Combinators;
using Specification_OCPrinciple.Specification;

namespace Specification_OCPrinciple
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Grey, Size.Large);

            Product[] products = { apple, house, tree };

            var pf = new ProductFilter();

            Console.WriteLine("Green products (old): ");
            foreach (var filtredProduct in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"- {filtredProduct.Name} is Green");
            }

            Console.WriteLine(new String('-', 15));
            Console.WriteLine("Specification");
            Console.WriteLine(new String('-', 15));

            var bf = new BetterFilter();
            Console.WriteLine("LargeProducts");

            var largeSpec = new SizeSpecification(Size.Large);

            foreach (var product in bf.Filter(products, largeSpec))
            {
                Console.WriteLine($"{product.Name}, -- {product.Size}");
            }

            Console.WriteLine(new String('-', 15));
            Console.WriteLine("Specification and Combinator");
            Console.WriteLine(new String('-', 15));

            var largeGreenSpec = new CombinatorSpecification(
                new SizeSpecification(Size.Large),
                new ColorSpecification(Color.Green));

            Console.WriteLine("Large AND Green Products");

            foreach (var product in bf.Filter(products, largeGreenSpec))
            {
                Console.WriteLine($"{product.Name}, -- {product.Size}");
            }
        }
    }
}