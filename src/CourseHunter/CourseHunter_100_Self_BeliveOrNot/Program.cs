using System;

namespace CourseHunter_100_Self_BeliveOrNot
{

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Questions.csv");
            game.EndOfGame += (sender, e) =>
            {
                Console.WriteLine($"Questions asked: {e.QuestionsPassed}. Mistakes made:{e.MistacesMade}");
                Console.WriteLine(e.IsWin ? "You won." : "You lost");
            };
            while (game.GameStatus == GameStatus.GameIsProgress)
            {
                Questions q = game.GetNextQuestions();
                Console.WriteLine("Do you belive? Enter y/n !");
                Console.WriteLine(q.Text);

                string answer = Console.ReadLine();
                bool boolAnswer = answer == "y";

                if (q.CorrectAnswer == boolAnswer)
                {
                    Console.WriteLine("Good job, You are right");
                }
                else
                {
                    Console.WriteLine("You are wrong");
                    Console.WriteLine(q.Explanation);
                }
                game.GiveAnswer(boolAnswer);
            }
            Console.ReadLine();
        }
    }
}
