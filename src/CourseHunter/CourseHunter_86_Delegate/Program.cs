using System;

namespace CourseHunter_86_Delegate
{
    public class Car
    {
        int speed = 0;

        // 1.    Объявляем делегат. Который описывает сигнатуру того метода который будет вызываться. Синтаксис делегата. 
        public delegate void TooFast();

        // 2.    Объявить переменную типа делегата. Экземпляр делегата.
        private TooFast tooFast;

        public void Start()
        {
            speed = 10; 
        }

        public void Accelerate()
        {
            speed += 10;
            if (speed > 90)
            {
                tooFast();      // 5.       Вызываем его.
            }
        }

        public void Stop()
        {
            speed = 0;
        }

        // 3. Метод обаботчик. Либо в конструкторе подисываемся на него либо отдельный метод. 
        public void RegisterOnTooFast (TooFast tooFast)
        {
            // 4.       Запоминаем его в филду.
            this.tooFast = tooFast;
        }

    }


    class Program
    {
        static Car car;

        static void Main(string[] args)
        {
            car = new Car();

            car.RegisterOnTooFast(HandleOnTooFast);

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }

            // Нам нужно уведомление с нижнего уровня,что хватит прибавлять скорость.

            Console.ReadLine();
        }
        

        //      6. Клиенская часть. Создаем обработчик. 
        private static void HandleOnTooFast()
        {
            Console.WriteLine("Oh, I got it, calling stop!");
            car.Stop();
        }
    }
}
