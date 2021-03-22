using System;

namespace CourseHunter_88_Self_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessNumberGame guessNumberGame = new GuessNumberGame(20, 5,guessingPlayer: GuessingPlayer.Mashine);
            guessNumberGame.Start();

            Console.ReadLine();
        }
    }
}
