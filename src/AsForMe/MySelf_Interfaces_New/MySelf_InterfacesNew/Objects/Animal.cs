using MySelf_InterfacesNew.Interfaces;

namespace MySelf_InterfacesNew.Objects
{
    class Animal : IMove
    {
        public string Name { get; set; }


        public void Move()
        {
            Console.WriteLine($"{typeof(Animal).Name} with {Name} is moving");
        }
    }
}
