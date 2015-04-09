namespace Bank.Customers
{
    public class Company : Customer, IPrintable
    {
        public Company(string inputFirstName)
            : base(inputFirstName)
        {
        }

        /// <summary>
        /// Returns string with companys name.
        /// </summary>
        /// <returns></returns>
        public override string DisplayCustomersName()
        {
            return string.Format("Customer type: Company.\nCompanys name: {0}", base.DisplayCustomersName());
        }
    }
}
