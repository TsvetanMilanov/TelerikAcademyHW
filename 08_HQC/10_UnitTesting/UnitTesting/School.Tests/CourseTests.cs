namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SchoolSystem;

    [TestClass]
    public class CourseTests
    {
        private static IList<Student> listOfRandomStudents;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            int studentsToAddCount = 40;
            listOfRandomStudents = CreateRandomStudents(studentsToAddCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingCourseWithNullListOfStudentsShouldThrowArgumentNullException()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        public void AddingValidNumberOfStudentToCourseShouwdProperlyAddStudents()
        {
            Course course = new Course();
            int validStudentsCount = 29;

            for (int i = 0; i < validStudentsCount; i++)
            {
                course.AddStudent(listOfRandomStudents[i]);
            }

            Assert.AreEqual(validStudentsCount, course.ListOfStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingInvalidNumberOfStudentToCourseSHouldThrowInvalidOperationException()
        {
            Course course = new Course();
            int invalidStudentsCount = 30;

            for (int i = 0; i < invalidStudentsCount; i++)
            {
                course.AddStudent(listOfRandomStudents[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullStudentShouldThrowArgumentNullException()
        {
            Student nullStudent = null;
            Course course = new Course();

            course.AddStudent(nullStudent);
        }

        [TestMethod]
        public void RemovingStudentFromCourseShouldRemoveTheProperStudent()
        {
            Course course = new Course();
            int validStudentsCount = 29;

            for (int i = 0; i < validStudentsCount; i++)
            {
                course.AddStudent(listOfRandomStudents[i]);
            }

            Student studentToRemove = course.ListOfStudents[2];

            course.RemoveStudent(studentToRemove);

            bool containsRemovedStudent = course.ListOfStudents.Contains(studentToRemove);

            Assert.IsFalse(containsRemovedStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullStudentShouldThrowArgumentNullException()
        {
            Student nullStudent = null;
            Course course = new Course();

            course.RemoveStudent(nullStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingNonExistingStudentShouldThrowInvalidOperationException()
        {
            int addedStudentsCount = 5;
            Student studentToRemove = listOfRandomStudents[addedStudentsCount + 1];
            Course course = new Course();

            for (int i = 0; i < addedStudentsCount; i++)
            {
                listOfRandomStudents.Add(listOfRandomStudents[i]);
            }

            course.RemoveStudent(studentToRemove);
        }

        private static IList<Student> CreateRandomStudents(int studentsCount)
        {
            IList<Student> listOfRandomStudents = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                Student studentToAdd = new Student("RandomStudent #" + i, 10000 + i);

                listOfRandomStudents.Add(studentToAdd);
            }

            return listOfRandomStudents;
        }
    }
}
