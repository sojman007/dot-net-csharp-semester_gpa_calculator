using System;
using System.Collections.Generic;
using System.Text;
namespace MyCustomApplication.Manager
{
    class Student
    {
        //props
        private readonly string Name;
        private readonly int Level;
        private Course[] CourseList;
        //getters
        public string GetName() => Name;
        public int Getlevel() => Level;
        public Course[] GetCourseList() => CourseList;
        //constructor
        public Student(string Name, int Level, Course[] courses)
        {
            this.Name = Name;
            this.Level = Level;
            CourseList = courses;
        }


    }

    
}
