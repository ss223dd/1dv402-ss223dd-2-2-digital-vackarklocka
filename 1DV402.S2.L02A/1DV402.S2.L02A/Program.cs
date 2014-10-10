using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class Program
    {
        // Simply a line (across the whole console window) seperating the different tests.
        private string HorizontalLine;

        // Method which instantiates "AlarmClock-objects" and tests the constructors, the properties and the methods. 7 tests in total.

        static void Main(string[] args)
        {
            Console.Title = "Digital Väckarklocka - Nivå A";

        // 1: Test of the default constructor to verify the status of the new object - the string "0:00 (0:00)" corresponding to the object's value should be presented.

        
        
        // 2: Test of the constructor with 2 parameters.
        // Use of the arguments 9 and 42 (9, 42) when instantiating a new object and the time to be presented is 9:42 (0:00).



        // 3: Constructor with 4 parameters.
        // Use Arg's: 13, 24, 7 and 35. Time to be presented: 13:24 (7:35).



        // 4: Test of the meth TickTock() making the clock turn 1 min.
        // Sets an existing AC-obj to 28:58 and let it run for 13 min. A list of 13 time stamps should be presented where the mins increase with 1 for each time stamp.
        // The hours should switch from 23 to 0 and when it turns to 0 it should be presented with just the one digit but the mins with the commencing 0.



        // 5: Sets the time of an existing AC-obj to 6:12, the alarm to 6:15 and makes it run for 6 min. The code should indicate when the alarm is being triggered.



        // 6: Test of the properties verifying exceptions being thrown when time/alarm is being assigned invalid values.
 


        // 7: Test of constructors making sure exceptions are being thrown when time/alarm is being assigned invalid values.



        
        }

        // Method with 2 parameters.
        // 1st one: a reference to an AlarmClock object.
        // 2nd one: the amount of minutes an AC-obj should run (by letting an object make numerous calls to the TickTock-method through an iteration).
        private static void Run(AlarmClock ac, int minutes)
        {

        }

        // Method which receives an exception in form of an argument and presents it (the error messages from the tests). 
        private static void ViewErrorMessage(string message)
        {

        }

        // Method which receives a string as an argument and presents it (the headers of each test).
        private static void ViewTestHeader(string header)
        {

        }
    }
}
