namespace Bank.Customers
{
    public abstract class Customer : IPrintable
    {
        public Customer(string inputName)
        {
            this.Name = inputName;
        }

        /// <summary>
        /// Customers name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Returns string with customers name.
        /// </summary>
        /// <returns></returns>
        public virtual string DisplayCustomersName()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
