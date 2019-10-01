using System;
using MyCustomApplication.Manager;
using System.Collections.Generic;
using System.Text;

namespace MyCustomApplication.Runtime
{
    class Menu
    {
        public ApplicationStateManager _;
        public Menu()
        {
            _ = new ApplicationStateManager();
            _.setUserInSession(true);
        }
        public bool DisplayMainMenu()
        {
            //Console.Clear();
            Console.WriteLine(" MAIN MENU" + "\nPlease type an Option Below:" +
                " \n * Launch Grade Calculator (G)*" +
                " \n * Settings (S) *" +
                " \n * About (A) *" +
                " \n * Exit (E) *");
            switch (Console.ReadLine())
            {
                case "G":
                    DisplayGradeCalculatorMenu();
                    break;

                case "S":
                    DisplaySettingsPage();
                    break;

                case "A":
                    DisplayAboutPage();
                    break;

                case "E":
                    _.setUserInSession(false);
                    break;

            }

            return true;
        }

        public void DisplayGradeCalculatorMenu()
        {

            _.setUserInGradeCalculator(true);
            while (_.getIsUserInGradeCalculator() == true && _.getUserInSession()==true)
            {
                Console.Clear();
                Console.WriteLine("\t_____________________________________________");
                Console.WriteLine("\t |SEMESTER \t GPA \t CALCULATOR|.v01");
                Console.WriteLine("\t---------------------------------------------\n");

                Console.WriteLine("\n GRADE CALCULATOR: Please Select an Option (upper case only) " +
                    " \n * Record Your Details [N] * " +
                    " \n * View Saved Data [V] *" +
                    " \n * Calculate GPA [C] *" +
                    " \n * Back To Main Menu [B] *"
                    );

                switch (Console.ReadLine())
                {
                    case "N":
                        recordUserData();
                        break;
                    case "V":
                        Console.WriteLine("View Data");
                        break;
                    case "C":
                        Console.WriteLine("Calculate GPA");
                        break;
                    case "B":
                        _.setUserInGradeCalculator(false);
                        break;

                }

 
            }
  
        }
        public void DisplaySettingsPage()
        {
            _.setUserInSettingsPage(true);
            Console.Clear();
            while (_.getUserInSettingsPage())
            {
                Console.WriteLine("\t_____________________________________________");
                Console.WriteLine("\t |SEMESTER \t GPA \t CALCULATOR|.v01");
                Console.WriteLine("\t---------------------------------------------\n");

                Console.WriteLine("Settings Page"
                    +
                    "\n * Return To Main Menu [E] *");
                string next = Console.ReadLine();
                if (next == "E")
                {
                    _.setUserInSettingsPage(false);
                }
                else
                {
                    Console.WriteLine("invalid Option!!");
                    Console.Clear();
                }

            }
            
        }
        public void DisplayAboutPage()
        {
            _.setUserInAboutPage(true);
            Console.Clear();

            while (_.getUserInAboutPage())
            {
                Console.WriteLine("\t_____________________________________________");
                Console.WriteLine("\t |SEMESTER \t GPA \t CALCULATOR|.v01");
                Console.WriteLine("\t---------------------------------------------\n");

                Console.WriteLine("About Page"
                    +
                    "\n * Return To Main Menu [E] *");
                string next = Console.ReadLine();
                if (next == "E")
                {
                    _.setUserInAboutPage(false);
                }
                else {
                    Console.WriteLine("invalid Option!!");
                    Console.Clear();
                }

            }

        }
        public void recordUserData()
        {
            _.setRecordingUserData(true);
            Console.Clear();
            while(_.getUserInSession() && _.getIsUserInGradeCalculator() && _.getRecordingUserData())
            {
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Level: ");
                string level = Console.ReadLine();
                Console.WriteLine("Enter Number Of Courses: ");
                string totalCourses = Console.ReadLine();
                Course[] AllCourses = new Course[int.Parse(totalCourses)];
                for(int rounds= 1; rounds <= AllCourses.Length ; rounds++)
                {
                    Console.WriteLine("Course " + rounds + ":Enter Course Title: ");
                    string courseTitle = Console.ReadLine();
                    Console.WriteLine("Course " + rounds + ":Enter Course Code: ");
                    string courseCode = Console.ReadLine();

                    Console.WriteLine("Course " + rounds + ":Enter Course Units: ");
                    string courseUnits = Console.ReadLine();

                    Console.WriteLine("Course " + rounds + ":Enter Course Score: ");
                    string courseScore = Console.ReadLine();
                    Console.WriteLine(" Done!!  ");
                    Course Target = new Course(int.Parse(courseUnits), courseCode, courseTitle,double.Parse(courseScore) );
                    AllCourses[rounds-1] = Target;
                    Console.WriteLine("Code: {0}, Units: {1} , Title: {2} ,Score: {3} ", Target.GetCourseCode(),Target.GetNumberOfUnits(), Target.GetFullCourseName(),Target.GetScore());

                }
                Console.WriteLine("Type [S] to finish recording Data");

                string nextOp = Console.ReadLine();
                if (nextOp == "S")
                {
                    _.setRecordingUserData(false);
                }

            }

        }
    }
}
