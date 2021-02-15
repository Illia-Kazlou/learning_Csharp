namespace CourseHunter_51_Classes
{
    class Character
    {
        //public
        //internal
        //protected

        private int health = 100;  //полке класса, по сути переменная

        public int Health // свойства
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

        // метод созданный вне класса в других языках программирования называется функцией.
        // в С# только методы.
        public void Hit(int damage)
        {
            if (damage > damage)
            {
                damage = health;
            }

            //health -= damage;

            Health -= damage;
        }
    }
}
