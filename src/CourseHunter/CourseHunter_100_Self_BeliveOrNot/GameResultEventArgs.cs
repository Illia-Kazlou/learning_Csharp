using System;

namespace CourseHunter_100_Self_BeliveOrNot
{
    public class GameResultEventArgs : EventArgs 
    {
        public GameResultEventArgs(int questionsPassed, int mistacesMade, bool isWin)
        {
            QuestionsPassed = questionsPassed;
            MistacesMade = mistacesMade;
            IsWin = isWin;
        }

        public int QuestionsPassed { get; }
        public int MistacesMade { get; }
        public bool IsWin { get; }
    }
}
