using MySelf_InterfacesNew.Interfaces;

namespace MySelf_InterfacesNew.Objects
{
    class Person : IMove
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void Move()
        {
            Console.WriteLine($"{typeof(Person).Name} with {Name} is moving");
        }
    }
}
