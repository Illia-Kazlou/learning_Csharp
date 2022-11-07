using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public enum Relationship
    {
        Parent, 
        Chield,
        Siblings
    }

    public class Person
    {
        public string Name { get; set; }
    }

    // low-level module
    public class Relationships : IRelationshipBrouser
    {
        private List<(Person, Relationship, Person)> relation = new List<(Person, Relationship, Person)> ();

        public void AddParentAndChield(Person parent, Person chield)
        {
            relation.Add((parent, Relationship.Parent, chield));
            relation.Add((chield, Relationship.Chield, parent));
        }

        public IEnumerable<Person> FindAllChildrensOf(string parentName)
        {
            return relation
                .Where(x => x.Item1.Name == parentName && x.Item2 == Relationship.Parent)
                .Select(r => r.Item3);
        }

        // ЭТО УЖЕ НЕ НУЖНО БУДЕТ
        public List<(Person, Relationship, Person)> Relations => relation;

        //public List<(Person, Relationship, Person)> Relations
        //{
        //    get
        //    {
        //        return relation;
        //    }
        //}
    }

    public class Research
    {
        /// ПРОБЛЕМА ЗДЕСЬ Т.К У НАС ВЫСОКОУРОВНЕВЫЙ КОД ЗАВИСИТ ОТ НИЗКОУРОВНЕГО
        //public Research(Relationships relationships)
        //{
        //    // Т.Е ЗДЕСЬ МЫ ВЛЕЗЛИ В ЕГО СПЕЦИФИКУ
        //    var relations = relationships.Relations;

        //    foreach (var item in relations
        //        .Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent ))
        //    {
        //        // Т.Е ЗДЕСЬ МЫ ВЛЕЗЛИ В ЕГО СПЕЦИФИКУ ХРАНЕНИЯ ДАННЫХ
        //        Console.WriteLine($" John has child called {item.Item3.Name} ");
        //    }
        //}

        public Research(IRelationshipBrouser relationshipBrouser)
        {
            foreach (var item in relationshipBrouser.FindAllChildrensOf("John"))
            {
                Console.WriteLine($" John has child called {item.Name} ");
            }
        }
    }

    // ДЛЯ РЕШЕНИЯ ЭТОЙ ПРОБЛЕМЫ НАМ НАДО НАДО СООРУДИТЬ КАКУЮ ТО ОБСТРАКЦИЮ
    public interface IRelationshipBrouser
    {
        IEnumerable<Person> FindAllChildrensOf(string parentName);
    }


    internal class Program
    {
        // DI no equal Dependency Inversion



        static void Main(string[] args)
        {
            var parent = new Person { Name = "John" };
            var chield1 = new Person { Name = "Max" };
            var chield2 = new Person { Name = "Matt" };

            var relationships = new Relationships();
            relationships.AddParentAndChield(parent, chield1);
            relationships.AddParentAndChield(parent, chield2);

            new Research(relationships);

            Console.ReadLine();
        }
    }
}
