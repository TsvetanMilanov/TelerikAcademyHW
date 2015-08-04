namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SchoolSystem;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingSchoolWithNullListOfCoursesShouldThrowArgumentNullException()
        {
            School school = new School(null);
        }

        [TestMethod]
        public void SchoolGetListOfCoursesShouldReturnCopyOfTheCollection()
        {
            IList<Course> listOfCoursesToAdd = new List<Course>();

            for (int i = 0; i < 3; i++)
            {
                listOfCoursesToAdd.Add(new Course());
            }

            School school = new School(listOfCoursesToAdd);

            var copyOfTheCoursesList = school.ListOfCourses;

            copyOfTheCoursesList = null;

            Assert.AreEqual(listOfCoursesToAdd.Count, school.ListOfCourses.Count);
        }
    }
}
