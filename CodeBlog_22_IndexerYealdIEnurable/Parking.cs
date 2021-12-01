using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlog_22_IndexerYealdIEnurable
{
    public class Parking
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_PLACES = 100;

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(car => car.Number == number);
                return car;
            }
        }

        public string Name { get; set; }

        public int GetCount()
        {
            return _cars.Count;
        }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car not be null");
            }

            if (_cars.Count < MAX_PLACES)
            {
                _cars.Add(car);

                return _cars.Count - 1;
            }

            return -1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is not null");
            }

            var car = _cars.FirstOrDefault(car => car.Number == number);

            if (car != null)
            {
                _cars.Remove(car);
            }
        }
    }
}
