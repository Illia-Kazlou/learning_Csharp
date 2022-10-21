namespace MySelf_Inherit
{
    public class Apple : Product
    {
        public string Testy { get; set; }

        public Apple(int id, string name, string color, string size, string testy) : base(id, name, color, size)
        {
            Testy = testy;
        }
    }
}