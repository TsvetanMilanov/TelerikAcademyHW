namespace Exceptions
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private const int MinProblemsCount = 0;
        private const int MaxProblemsCount = 2;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                Validator.CheckIfNegativeNumber(value, "Problems solved");
                Validator.CheckIfValueIsInRange(
                                                value,
                                                MinProblemsSolved,
                                                MaxProblemsSolved,
                                                "Problems solved");

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            Validator.CheckIfValueIsInRange(
                                            this.ProblemsSolved,
                                            MinProblemsCount,
                                            MaxProblemsCount,
                                            "Problems solved");

            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else
            {
                return new ExamResult(6, 2, 6, "Good result: Everything done.");
            }
        }
    }
}