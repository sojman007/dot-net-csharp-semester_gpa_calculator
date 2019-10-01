
namespace MyCustomApplication.Manager
{
    class Course
    {
        private int NumberOfUnits;
        private string CourseCode;
        private string FullCourseName;
        private double Score;
        //getters
        public double GetScore()
        {
            return Score;
        }
        public string GetCourseCode()
        {
            return CourseCode;
        }
        public string GetFullCourseName()
        {
            return FullCourseName;
        }
        public int GetNumberOfUnits()
        {
            return NumberOfUnits;
        }



        //constructor
        public Course(int units, string code, string fullName, double ScoreValue)
        {
            NumberOfUnits = units;
            CourseCode = code;
            FullCourseName = fullName;
            Score = ScoreValue;
        }

        
    }
}
