namespace CourseHunter_77_Enumeration
{
    public class Character
    {
        private readonly int speed = 10;

        public int Health { get; set; } = 100;

        public string Race { get; set; }

        public int Armor { get; set; }

        public Character() //- конструктор по умолчанию.
        {

        }

        public Character(string race)
        {
            Race = race;
            Armor = 10;
        }

        public Character(string race, int armor)
        {
            Race = race;
            Armor = armor;
        }
    }
}
