using System;
using MyCustomApplication.Manager;
using System.Collections.Generic;
using System.Text;

namespace MyCustomApplication.Runtime
{
    class Menu
    {
        private readonly ApplicationStateManager _AppState;
        public ApplicationStateManager GetApplicationState()=>  _AppState; 
        public Menu()
        {
            _AppState = new ApplicationStateManager();
            _AppState.setUserInSession(true);
        }
        public bool DisplayMainMenu()
        {
            
            DisplayBanner();
            Console.WriteLine(" MAIN MENU" + "\nPlease type an Option Below:" +
                " \n * Launch Grade Calculator (G) *" +
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
                    _AppState.setUserInSession(false);
                    break;

            }

            return true;
        }

        public void DisplayGradeCalculatorMenu()
        {

            _AppState.setUserInGradeCalculator(true);
            while (_AppState.getIsUserInGradeCalculator() == true && _AppState.getUserInSession()==true)
            {
                Console.Clear();
                DisplayBanner();
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
                        viewData();
                        break;
                    case "C":
                        Console.WriteLine("Calculate GPA");
                        break;
                    case "B":
                        _AppState.setUserInGradeCalculator(false);
                        break;

                }

 
            }
  
        }
        void DisplayBanner()
        {
            Console.WriteLine("\t_____________________________________________");
            Console.WriteLine("\t |SEMESTER \t GPA \t CALCULATOR|.v01");
            Console.WriteLine("\t---------------------------------------------\n");

        }
        public void DisplaySettingsPage()
        {
            _AppState.setUserInSettingsPage(true);
            Console.Clear();
            while (_AppState.getUserInSettingsPage())
            {
                DisplayBanner();                
                Console.WriteLine("Settings Page"
                    +
                    "\n * Return To Main Menu [E] *");
                string next = Console.ReadLine();
                if (next == "E")
                {
                    _AppState.setUserInSettingsPage(false);
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
            _AppState.setUserInAboutPage(true);
            Console.Clear();

            while (_AppState.getUserInAboutPage())
            {
                DisplayBanner();
                Console.WriteLine("About Page"
                    +
                    "\n * Return To Main Menu [E] *");
                string next = Console.ReadLine();
                if (next == "E")
                {
                    _AppState.setUserInAboutPage(false);
                }
                else {
                    Console.WriteLine("invalid Option!!");
                    Console.Clear();
                }

            }

        }
        void viewData()
        {
             
        }
         void recordUserData()
        {
            _AppState.setRecordingUserData(true);
            Console.Clear();
            while(_AppState.getUserInSession() && _AppState.getIsUserInGradeCalculator() && _AppState.getRecordingUserData())
            {
                DisplayBanner();
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
                //what if we saved that exact data to the application state.??
                Console.WriteLine("Type [S] to finish recording Data");

                string nextOp = Console.ReadLine();
                if (nextOp == "S")
                {
                    _AppState.setRecordingUserData(false);
                    //connect  and save to database here
                }

            }

        }
    }
}
