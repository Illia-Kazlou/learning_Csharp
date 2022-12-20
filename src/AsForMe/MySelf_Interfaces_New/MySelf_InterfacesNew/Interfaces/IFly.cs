namespace MySelf_InterfacesNew.Interfaces
{
    public interface IFly
    {
        const int minSpeed = 0;
        static int maxSpeed = 1000;

        public void Fly()
        {
            Console.WriteLine("FLY FLUE FLOVEN");
        }
    }
}