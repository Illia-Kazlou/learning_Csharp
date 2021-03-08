// Сгрупированные именованные константыю
namespace CourseHunter_77_Enumeration
{
    // Ключевое слово перечисления enumю
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    // По сути enum наследуется от int и имеет внутри структуру массиваю
    public enum Race : int
    {
        Human = 20,
        Elf = 10,
        Ork = 30,
        Dwarf = 40,
        NightElf = 10,
        Druid = 5,
    }

}
