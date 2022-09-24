using System;

namespace MySelf_OperatorYield
{
    class Person
    {
        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; set; }
        public int Id { get; set; }

    }
}
