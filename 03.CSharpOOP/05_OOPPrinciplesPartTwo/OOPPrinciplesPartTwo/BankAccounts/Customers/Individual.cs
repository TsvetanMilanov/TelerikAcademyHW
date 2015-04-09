namespace Bank.Customers
{
    public class Individual : Customer, IPrintable
    {
        public Individual(string inputName, string inputMiddleName, string inputLastName)
            : base(inputName)
        {
            this.MiddleName = inputMiddleName;
            this.LastName = inputLastName;
        }

        /// <summary>
        /// Individuals middlename.
        /// </summary>
        public string MiddleName { get; protected set; }

        /// <summary>
        /// Individuals lastname.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Returns string with all customers names.
        /// </summary>
        /// <returns></returns>
        public override string DisplayCustomersName()
        {
            return string.Format("Customer type: Individual.\nFirst name: {0}\nMiddle name: {1}\nLast name: {2}", base.DisplayCustomersName(), this.MiddleName, this.LastName);
        }
    }
}
