using System;
using System.Collections.Generic;

namespace MySelf_OperatorYield
{
    class Company
    {
        Person[] people;
        public int Lenght => people.Length;

        public Company(Person[] people)
        {
            this.people = people ?? throw new ArgumentNullException(nameof(people));
        }


        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < Lenght; i++)
            {
                yield return people[i];
            }
        }
    }
}
