using System;

namespace _10R_Self_methods
{
    public class Person
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public Person(string name, string secondname)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            SecondName = secondname ?? throw new ArgumentNullException(nameof(secondname));

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-10, 10);
            Y += rnd.Next(-20, 20);

            return $"{Name} {SecondName}, ({X},{Y})";
        }

        // перегрузка метода Run
        public string Run(int x, int y)
        {
            X += x;
            Y += y;

            return $"{Name} {SecondName}, ({X},{Y})";
        }

        public string Run(Person y)
        {
            return $"{Name} {SecondName}, ({X},{Y})";
        }
    }
}
