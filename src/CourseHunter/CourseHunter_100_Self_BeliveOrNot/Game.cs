using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourseHunter_100_Self_BeliveOrNot
{
    public enum GameStatus
    {
        GameIsOver,
        GameIsProgress,
    }

    public class Game
    {
        private readonly List<Questions> questions;
        private readonly int allowedMisaces;
        private int counter;
        private int mistaces;

        public event EventHandler<GameResultEventArgs> EndOfGame;  

        public Game(string filePath, int allowedMisaces = 2)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath");
            }

            if (filePath == "")
            {
                throw new ArgumentException("filePath should not be empty");
            }

            if (allowedMisaces <2)
            {
                throw new ArgumentException("Count mistaces can not be less 2");    
            }

            List<Questions> questions = File.ReadAllLines(filePath)
                                .Select(x =>
                                {
                                    string[] parts = x.Split(';');
                                    string text = parts[0];
                                    bool answer = parts[1] == "Yes";
                                    string description = parts[2];

                                    return new Questions(text, answer, description);
                                }).ToList() ;

            this.questions = questions;
            this.allowedMisaces = allowedMisaces;

            GameStatus = GameStatus.GameIsProgress;
        }

        public GameStatus GameStatus { get; private set; }

        public Questions GetNextQuestions()
        {
            return questions[counter];
        }

        public void GiveAnswer (bool answer)
        {
            if (questions[counter].CorrectAnswer != answer)
            {
                mistaces++;
            }

            if (counter == questions.Count -1 || mistaces > allowedMisaces)
            {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame!=null)
                {
                    EndOfGame(this, new GameResultEventArgs(counter, mistaces, mistaces <= allowedMisaces));
                }
            }
            counter++;
        }
    }
}
