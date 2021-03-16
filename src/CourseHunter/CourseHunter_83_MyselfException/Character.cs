using System;

namespace CourseHunter_83_MyselfException
{
    public class Character
    {
        //поле класса, по сути переменная
        //public static int health = 100;

        public static int Health { get; set; }

        public string Race { get; private set; }

        public int Armor { get; private set; }

        public Character(string race, int armor)
        {
            if (race == null)
            {
                // не дает передавать 0, в качестве оргумента к этому свойствую.
                throw new ArgumentNullException("Race can't be a null.");
            }
            if (armor < 0 || armor > 300)
            {
                // не корректное знччение оргумента.
                throw new ArgumentException("Armor can't be less zen 0 or more than 300.");
            }
            Race = race;
            Armor = armor;
        }

        public Character(string race, int armor, int health = 100) //optional parametrs
        {
            Race = race;
            Armor = armor;
            Health = health;
        }

        public static void Hit(int damage)
        {
            if (Health < 0)
            {
                throw new InvalidOperationException(); //Вызвали такое состояние в котором не предполся вызов метода.
            }
            if (damage >= Health)
            {
                throw new ArgumentException("Damage can't be more then health.");
            }


            if (damage >= Health)
            {
                Health = damage--;
            }

            Health -= damage;

        }
    }

}
