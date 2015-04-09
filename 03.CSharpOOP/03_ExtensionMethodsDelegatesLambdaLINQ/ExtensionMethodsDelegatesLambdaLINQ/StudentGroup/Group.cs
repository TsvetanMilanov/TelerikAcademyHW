namespace StudentGroup
{
    public class Group
    {
        public Group(int inputGroupNumber, string inputDepartmentName)
        {
            this.GroupNumber = inputGroupNumber;
            this.DepartmentName = inputDepartmentName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return string.Format("#{0} -> {1} department.", this.GroupNumber, this.DepartmentName);
        }
    }
}
