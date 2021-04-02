namespace CourseHunter_100_Self_BeliveOrNot
{
    public class Questions
    {
        public Questions(string text, bool correctAnswer, string explanation)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            Explanation = explanation;
        }

        public string Text { get; }
        public bool CorrectAnswer { get; }
        public string Explanation { get; }
    }
}
