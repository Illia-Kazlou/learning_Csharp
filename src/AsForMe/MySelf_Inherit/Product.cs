namespace MySelf_Inherit
{
    public abstract class Product
    {
        protected Product(int id, string name, string color, string size)
        {
            Id = id;
            Name = name;
            Color = color;
            Size = size;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }
    }
}

