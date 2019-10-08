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

            while (MyMenu.GetApplicationState().getUserInSession() == true)

            {
                Console.Clear();
                MyMenu.DisplayMainMenu();
               
                } 


        }
    }
}
