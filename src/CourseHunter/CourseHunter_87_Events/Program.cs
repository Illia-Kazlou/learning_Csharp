using System;
using System.Timers;

namespace CourseHunter_92_Events
{
    public class Car
    {
        // Для того чтобы не городить весь этот огород ниже. Есть такие конструкции как Event.
        // События сигнализируют системе о том, что произошло определенное действие. 
        // И если нам надо отследить эти действия, то как раз мы можем применять события.
        // Надстройка над делегатом.
        // Безопасность, элегантность и красткость синтаксиса.


        int speed = 0;

        // public event Action<object, int> TooFastDriving; // специальный евент при котором даже делега не надо объявлять. Он сделан за нас
        // public event Func<int> TooFastDriving;  если мы хотим нписать функцию которая не только принимает параметры но и отдает
        public event EventHandler<int> TooFastDriving;


        public delegate void TooFast(int curentSpeed);

        // public event TooFast TooFastDriving;


        // private TooFast tooFast; Объявить переменную типа делегата. Экземпляр делегата. НЕ НУЖНО!!!

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;
            if (speed > 90)
            {
                if (TooFastDriving != null)   // Ивенты надо проверять на null.
                {
                    TooFastDriving(this, speed);      // 5.       Вызываем ивент.
                }
            }
        }

        public void Stop()
        {
            speed = 0;
        }


        // И это нам тоже не нужно!!!!!
        //public void RegisterOnTooFast (TooFast tooFast)
        //{
        //    // 4.       Запоминаем его в филду.
        //    this.tooFast += tooFast;
        //}

        //public void UnRegisterOnTooFast(TooFast tooFast)
        //{
        //    // 4.       Запоминаем его в филду.
        //    this.tooFast -= tooFast;
        //}

    }


    class Program
    {
        //static Car car;

        static void Main(string[] args)
        {
            Car car = new Car();

            // Теперь подписыватся нужно не через методы а на прямую через ивент.
            //car.RegisterOnTooFast(HandleOnTooFast);
            //// Делегат можно вызывать дважды. Присоединять.
            //car.RegisterOnTooFast(HandleOnTooFast);

            //// Также можно и отсоединять.
            //car.UnRegisterOnTooFast(HandleOnTooFast);

            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;
            car.TooFastDriving += HandleOnTooFast;

            car.TooFastDriving -= HandleOnTooFast;

            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }


            Console.WriteLine(new string ('-', 50));

            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;

            timer.Interval = 5000;
            timer.Start();

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // var timer = (Timer)sender; // ссылка на объект который генерирует объект. Такой стиль - это то соглашение програмисстов.
            Console.WriteLine("Timer hendler");
        }


        //      6. Клиенская часть. Создаем обработчик. 
        private static void HandleOnTooFast(object obj, int speed)
        {
            Console.WriteLine("Oh, I got it, calling stop!");
            var car = (Car)obj;
            car.Stop();
        }
    }
}
