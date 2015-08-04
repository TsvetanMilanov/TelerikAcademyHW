namespace Exceptions
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            Validator.CheckIfMaxValueIsBiggerThanMinValue(
                                                        minGrade, 
                                                        maxGrade,
                                                        "ExamResult min value",
                                                        "ExamResult max value");

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                Validator.CheckIfNegativeNumber(value, "ExamResult grade");

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                Validator.CheckIfNegativeNumber(value, "ExamResult min grade");

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                Validator.CheckIfNegativeNumber(value, "EcamResult max grade");

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                Validator.CheckIfStringIsValid(value, "ExamResult comments");

                this.comments = value;
            }
        }
    }
}