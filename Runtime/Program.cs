using System;
using MyCustomApplication.Manager;
using MyCustomApplication.Utils;
namespace MyCustomApplication.Runtime
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Menu MyMenu = new Menu();

            while (MyMenu._.getUserInSession() == true)

            {
                Console.Clear();
                Console.WriteLine("\t_____________________________________________");
                Console.WriteLine("\t |SEMESTER \t GPA \t CALCULATOR|.v01");
                Console.WriteLine("\t---------------------------------------------\n");
                MyMenu.DisplayMainMenu();
               
                } 


        }
    }
}
