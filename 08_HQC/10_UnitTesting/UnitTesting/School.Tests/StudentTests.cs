namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SchoolSystem;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStudentWithEmptyNameShouldThrowArgumentException()
        {
            Student student = new Student(string.Empty, 15000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStudentWithNullNameShouldThrowArgumentException()
        {
            Student student = new Student(null, 15000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStudentWithWhiteSpaceNameShouldThrowArgumentException()
        {
            Student student = new Student("  ", 15000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateStudentWithExistingNumberShouldThrowArgumentException()
        {
            Student firstStudent = new Student("Peter", 15000);

            Student secondStudent = new Student("John", 15000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStudentWithSmallNumberShouldThrowArgumentOutOfRangeException()
        {
            Student firstStudent = new Student("Peter", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateStudentWithBigNumberShouldThrowArgumentOutOfRangeException()
        {
            Student firstStudent = new Student("Peter", 100000);
        }
    }
}
