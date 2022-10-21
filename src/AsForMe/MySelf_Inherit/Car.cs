namespace MySelf_Inherit
{
    public class Car : Product
    {
        public int Speed { get; set; }

        public Car(int id, string name, string color, string size, int speed) : base(id, name, color, size)
        {
            Speed = speed;
        }

    }
}

