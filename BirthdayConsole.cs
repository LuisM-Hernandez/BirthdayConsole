using System;

namespace BirthdayConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tcondition = true;

            while(tcondition)
            {

             //We create an output that ask us to input our names
            Console.WriteLine("What is your name");
            // We create a string that store our input
            string userName = Console.ReadLine();

            // We create an output that ask our birthdate
            Console.WriteLine("Please enter your birthdate in the following format mm/dd/yyyy");

           // User Input Data
          var userInput = Console.ReadLine();
          // Converts users input to the DateTime format
          var userDate = Convert.ToDateTime(userInput);
          // We create a variable which will be the current date
          var actualDate = DateTime.Now;
          // We create a variable that represents the users input day
          var inputDay = userDate.Day;
          // We create a variable that represents the users input month
          var inputMonth = userDate.Month;
          // We create a variable that represents the users input year
          var inputYear = userDate.Year;
          // We create a variable that represents current day
          var actualDay = actualDate.Day;
          // We create a variable that represents current month
          var actualMonth = actualDate.Month;
          // We create a variable that represents current year
          var actualYear = actualDate.Year;
         // We create a variable that substract the actual year with the input year and gives us our age
          var age = actualYear - inputYear;

         // We create an if else code block that will compare our input day and month with the current day and month
         // so if it meets the same values it says "Happy Birthday"

          if (inputDay == actualDay  && inputMonth == actualMonth)
         {
             Console.WriteLine("Happy Birthday "+ userName + " you are " + age + " years old" );
         }

         else
         {
             Console.WriteLine("Hi " + userName + " you are " + age + " years old");
         }

           // ask the user if they want to quit
          // if user enters 'q' it read the users input and breaks
          Console.WriteLine("Press 'q' to quit");
          var quit = Console.ReadLine();
                 if(quit == "q")
          {
              tcondition = false;
          }
            }
            
            
            
            
        }
    }
}
