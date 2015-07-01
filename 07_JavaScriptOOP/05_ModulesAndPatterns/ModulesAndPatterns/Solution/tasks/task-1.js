/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    function checkIfStudentNameIsValid(name) {
        if (!name.match(/^[A-Z][a-z]+|^[A-Z]/)) {
            throw new Error('The name of the student is invalid!');
        }
    }

    var Student = (function () {
        var Student = function (firstname, lastname, id) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.id = id;
            this.homeworks = [];
            this.examScore = 0;
            this.finalscore = 0;
        };

        Student.prototype.calculateFinalScore = function (presentationsCount) {
            var homeworkScore = 0,
                examCoefficient = 0.75,
                homeworkCoefficient = 0.25;

            homeworkScore = this.homeworks.length / presentationsCount;

            this.finalscore = (examCoefficient * this.examScore) + (homeworkCoefficient * homeworkScore);
        };

        Student.prototype.sendHomework = function (homework) {
            this.homeworks.push(homework);
        };

        return Student;
    }());


    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this._students = [];
            this.presentations = presentations;
            return this;
        },
        addStudent: function (name) {
            if (!name) {
                throw new Error('The name of the student must not be empty!');
            }

            if (typeof (name) !== 'string') {
                throw new Error('The name of the student must be String!');
            }

            if (name.length <= 0) {
                throw new Error('The name of the student must not be empty!');
            }

            var studentNames = name.split(' ');

            var firstName = studentNames[0];
            var lastName = studentNames[1];

            if (studentNames.length > 2) {
                throw new Error('Student must have only two names!');
            }

            if (studentNames.length === 1) {
                throw new Error('Student must have two names!');
            }

            checkIfStudentNameIsValid(firstName);
            checkIfStudentNameIsValid(lastName);

            var studentID = this._students.length + 1;

            var student = new Student(firstName, lastName, studentID);

            this._students.push(student);

            return studentID;
        },
        getAllStudents: function () {
            return this._students.slice().map(function (student) {
                return {firstname: student.firstname, lastname: student.lastname, id: student.id};
            });
        },
        submitHomework: function (studentID, homeworkID) {
            var student = this.getStudentById(studentID);

            if (homeworkID % 1 !== 0 || homeworkID === 0 || homeworkID > this.presentations.length) {
                throw new Error('The homework ID must be valid!');
            }

            student.sendHomework(homeworkID);
        },
        getStudentById: function (id) {
            var students = this._students.filter(function (st) {
                return st.id === id;
            });

            if (students.length <= 0) {
                throw new Error('Invalid student id!');
            }

            return students[0];
        },
        pushExamResults: function (results) {
            results.forEach(function (result) {
                var studentId = result.StudentID,
                    studentScore = result.Score,
                    student = this.getStudentById(studentId);

                student.examScore = studentScore;
            });

            //return this._students;
        },
        getTopStudents: function () {
            var that = this,
                sortedStudents;

            this._students.forEach(function (student) {
                student.calculateFinalScore(that.presentations.length);
            });

            sortedStudents = this._students.sort(function (firstStudent, secondStudent) {
                return secondStudent.finalscore - firstStudent.finalscore;
            });

            return sortedStudents.slice(0, 10);
        }
    };

    Object.defineProperties(Course, {
        title: {
            get: function () {
                return this._title;
            },
            set: function (value) {
                if (!value) {
                    throw new Error('Title must not be empty!');
                }

                if (value.length <= 0) {
                    throw new Error('Title must not be empty!');
                }

                if (value[0] === ' ') {
                    throw new Error('Title must not start with space!');
                }

                if (value[value.length - 1] === ' ') {
                    throw new Error('Title must not end with space');
                }

                this._title = value;
                return this;
            }
        },
        presentations: {
            get: function () {
                return this._presentations;
            },
            set: function (value) {
                if (!value || value.length <= 0) {
                    throw new Error('Presentations must not be empty');
                }

                for (var i = 0; i < value.length; i += 1) {
                    var currentPresentation = value[i];
                    if (currentPresentation.indexOf('  ') > -1) {
                        throw new Error('Presentation title must not contain space!');
                    }

                    if (currentPresentation.length <= 0) {
                        throw new Error('Title of presentation must not be empty!');
                    }
                }

                this._presentations = value;
                return this;
            }
        }
    });

    return Course;
}

module.exports = solve;
