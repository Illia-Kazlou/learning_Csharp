using System;

namespace CourseHunter_88_Self_GuessNumber
{
    public enum GuessingPlayer
    {
        Human,
        Mashine,
    }

    public class GuessNumberGame
    {
        private readonly int _max;
        private readonly int _maxTries;
        private readonly GuessingPlayer _guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this._max = max;
            this._maxTries = maxTries;
            this._guessingPlayer = guessingPlayer;
        }

        public void Start()
        {
            if (_guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MashineGuesses();
            }
        }

        private void MashineGuesses()
        {
            Console.WriteLine("Enter a number that's going to be guessed by computer.");
            int guessedNumber = -1;
            while (guessedNumber == -1)
            {
                // TPDO: Check input data.
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this._max)
                {
                    guessedNumber = parsedNumber;
                }
            }

            int lastGuess = -1;
            int min = 0;
            int max = this._max;
            int tries = 0;

            while (lastGuess != guessedNumber && tries < _maxTries)
            {
                lastGuess = (max + min) / 2;
                Console.WriteLine($"Did you guesses this {lastGuess} number?");
                Console.WriteLine("If yes, enter 'y', if your number > - enter >, if your number < - enter < .");
                char answer = Convert.ToChar(Console.ReadLine());
                switch (answer)
                {
                    case 'y':
                        Console.WriteLine("Congats! You guessed the number.");
                        break;
                    case '>':
                        Console.WriteLine();
                        min = lastGuess;
                        tries++;
                        break;
                    case '<':
                        Console.WriteLine();
                        max = lastGuess;
                        tries++;
                        break;
                    default:
                        break;
                }

                if (lastGuess == guessedNumber)
                {
                    Console.WriteLine("You are a lier!");
                }

                if (tries == _maxTries)
                {
                    Console.WriteLine("I had losing(");
                }
            }

        }

        private void HumanGuesses()
        {
            Random random = new Random();
            int guessedNumber = random.Next(0, _max);

            int lastGuess = -1;
            int tries = 0;

            while (lastGuess != guessedNumber && tries < _maxTries)
            {
                Console.WriteLine("Guess the number.");
                // TPDO: Check input data.
                lastGuess = int.Parse(Console.ReadLine());

                if (lastGuess == guessedNumber)
                {
                    Console.WriteLine("Congats! You guessed the number.");
                    break;
                }
                else if (lastGuess < guessedNumber)
                {
                    Console.WriteLine($"Sorry! You are wrong. Your number {lastGuess} < guessing number. Try again.");
                    tries++;
                }
                else
                {
                    Console.WriteLine($"Sorry! You are wrong. Your number {lastGuess} > guessing number. Try again.");
                    tries++;
                }
            }
            if (tries == _maxTries)
            {
                Console.WriteLine("Sorry! You are lose.");
            }
        }
    }
}
