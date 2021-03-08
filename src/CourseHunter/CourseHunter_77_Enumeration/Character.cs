using CourseHunter_77_Enumeration;

namespace CourseHunter_77_Enumeration
{
    public class Character
    {
        public int Health { get; set; }

        public int Armor { get; private set; }

        // public Rase Rase { get; set; }

        public Race Race { get; set; }

        public Character() //- конструктор по умолчанию.
        {
            Race = this.Race;
        }

        public Character(Race race)
        {
            Race = race;
            Armor = (int)race;
        }

        public Character(Race race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        public Character(Race race, int armor, int health = 100) //optional parametrs
        {
            Race = race;
            Armor = armor;
            Health = health;
        }

        public override string ToString()
        {
            return $"{Race}, {Armor}";
        }
    }
}
