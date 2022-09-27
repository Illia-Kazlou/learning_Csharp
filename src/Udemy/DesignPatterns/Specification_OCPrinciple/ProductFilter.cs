namespace Specification_OCPrinciple
{
    class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)
                {
                    yield return product;
                }
            }
        }

        /// <summary>
        /// Этот коднарушает принцип открытости и закрытости, а так же он не маштабируемые
        /// State space explosion
        /// </summary>
        /// <param name="products"></param>
        /// <param name="color"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var product in products)
            {
                if (product.Color == color && product.Size == size)
                {
                    yield return product;
                }
            }
        }
    }
}