namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string inputFirstName, string inputLastName, decimal inputWeekSalary, int inputWorkHoursPerDay)
            : base(inputFirstName, inputLastName)
        {
            this.WeekSalary = inputWeekSalary;
            this.WorkHoursPerDay = inputWorkHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal result = 0;

            result = this.WeekSalary / (this.WorkHoursPerDay * 7);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}Week salary: {1}$\nWorkhours per day: {2}\nMoney per hour: {3:F2}$\n", base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
