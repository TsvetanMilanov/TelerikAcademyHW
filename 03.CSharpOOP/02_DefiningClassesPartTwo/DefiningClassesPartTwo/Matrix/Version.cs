namespace MatrixClass
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.VersionMajor = major;
            this.VersionMinor = minor;
        }

        public int VersionMajor { get; set; }

        public int VersionMinor { get; set; }
    }
}
