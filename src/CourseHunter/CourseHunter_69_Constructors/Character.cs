namespace CourseHunter_69_Constructors
{
    public class Character
    {
        //поле класса, по сути переменная
        //public static int health = 100;

        public int Health { get; set; }

        public string Race { get; private set; }

        public int Armor { get; private set; }

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

        public Character(string race, int armor, int health = 100) //optional parametrs
        {
            Race = race;
            Armor = armor;
            Health = health;
        }
    }

    public class Point2d 
    {
        private int x;
        private int y;

        public Point2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
