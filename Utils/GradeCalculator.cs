using System;
using MyCustomApplication.Manager;

namespace MyCustomApplication.Utils
{
    class GradeCalculator
    {
        public static double GetCourseGrade(Course course)
        {
           
            double gradePoint =0;
            double val = course.GetScore();
            

            if (val <=100 && val >=70) 
                {
                   gradePoint = 5;
                }
            else if(val<70 && val>=60){
                gradePoint =4;


              }else if(val<60 && val>=50){
                gradePoint =3;


              }else if(val<50 && val>=40){
                gradePoint =2;


              }else if(val<40 && val>=30){
                gradePoint =1;

                }

            return gradePoint;
        }

        public static double GetGradePointAverage(Course[] courses){
            double totalScore = 0;
            int totalUnits = 0;
            double average;
            foreach(Course course in courses){
                double courseGradeScore = GetCourseGrade(course);
                int units = course.GetNumberOfUnits();
                totalScore+= courseGradeScore;
                totalUnits += units;
            }
            average = totalScore/totalUnits;
            return average;
}

    }
}
