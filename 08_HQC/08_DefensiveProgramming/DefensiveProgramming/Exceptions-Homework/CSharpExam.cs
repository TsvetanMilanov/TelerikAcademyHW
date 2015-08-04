namespace Exceptions
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                Validator.CheckIfNegativeNumber(value, "CSharpExam score");
                Validator.CheckIfValueIsInRange(value, MinScore, MaxScore, "CSharpExam score");

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            Validator.CheckIfValueIsInRange(this.Score, MinScore, MaxScore, "CSharpExam score");

            return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        }
    }
}