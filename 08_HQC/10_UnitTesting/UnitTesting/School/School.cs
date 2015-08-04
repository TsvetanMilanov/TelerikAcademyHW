namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private IList<Course> listOfCourses;

        public School(IList<Course> listOfCourses)
        {
            this.ListOfCourses = listOfCourses;
        }

        public IList<Course> ListOfCourses
        {
            get
            {
                return this.listOfCourses.ToList();
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Schools list of courses must not be null!");
                }

                this.listOfCourses = value;
            }
        }
    }
}
