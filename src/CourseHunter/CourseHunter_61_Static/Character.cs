using System;

namespace CourseHunter_61_Static
{
    class Character
    {
        // Access modifier:

        // private
        //public
        //internal используется только внутри той сборки в которой он объявлен.
        //protected

        //полке класса, по сути переменная
        public int health = 100;

        public static int speed = 10;

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                health = value;
            }
        }

        // При компиляции свойсва преобразуются в методы GET & SET
        //public int GetHealth()
        //{
        //    return health;
        //}

        //public void SetHealth(int value)
        //{
        //    health = value;
        //}


        // метод созданный вне класса в других языках программирования называется функцией.
        // в С# только методы.
        public void Hit(int damage)
        {
            if (damage >= health)
            {
                health = damage--;
            }

            health -= damage;

            //Health -= damage;
        }

        public int PrintSpeed()
        {
            return speed;
        }

        public  void IncreedSpeed()
        {
            speed += 10;
        }
    }
}
