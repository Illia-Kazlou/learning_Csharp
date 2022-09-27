using Specification_OCPrinciple.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_OCPrinciple.Interfaces
{
    /// <summary>
    /// В рамках спецификации создаем интерфейс который будет фильтровать не важно что
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T>items, 
            // И вторым параметром будет интерфейс/абстрактный класс спецификации по которой будет проходить фильтрация
            BaseSpecification<T> specification
            );
    }
}
