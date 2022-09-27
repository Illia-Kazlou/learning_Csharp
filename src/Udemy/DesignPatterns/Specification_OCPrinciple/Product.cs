namespace Specification_OCPrinciple
{
    public partial class Product
    {
        public readonly int Id;
        public readonly string Name;
        public readonly Color Color;
        public readonly Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }
}