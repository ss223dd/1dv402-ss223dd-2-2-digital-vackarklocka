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
        private static string HorizontalLine = "═══════════════════════════════════════════════════════════════════════════════";

        // Method which instantiates "AlarmClock-objects" and tests the constructors, the properties and the methods. 7 tests in total.
        
        private static void Main(string[] args)
        {
            Console.Title = "Digital Väckarklocka - Nivå A";

            // Instantiates the default Alarmclock-object which will be used in the different tests below (in various forms/with various values/modifies depending on each test).
            AlarmClock alarmclock = new AlarmClock();

            // 1: Test of the default constructor to verify the status of the new object - the string "0:00 (0:00)" corresponding to the object's value should be presented.
            ViewTestHeader("Test 1.\nTest av standardkonstruktorn.");
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();
        
            // 2: Test of the constructor with 2 parameters.
            // Use of the arguments 9 and 42 (9, 42) when instantiating a new object and the time to be presented is 9:42 (0:00).
            ViewTestHeader("Test 2.\nTest av konstruktorn med två parametrar, (9, 42).");
            alarmclock = new AlarmClock(9, 42);
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();

            // 3: Constructor with 4 parameters.
            // Use arg's: 13, 24, 7 and 35. Time to be presented: 13:24 (7:35).
            ViewTestHeader("Test 3.\nTest av konstruktorn med fyra parametrar, (13, 24, 7, 35).");
            alarmclock = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();

            // 4: Test of the meth TickTock() making the clock turn 1 min.
            // Sets an existing AC-obj to 23:58 and let it run for 13 min. A list of 13 time stamps should be presented where the mins increase with 1 for each time stamp.
            // The hours should switch from 23 to 0 and when it turns to 0 it should be presented with just the one digit but the mins with the commencing 0.
            ViewTestHeader("Test 4.\nStäller befintligt AlarmClock-objekt till 23:58 och låter det gå 13 minuter.");
            alarmclock.Hour = 23;
            alarmclock.Minute = 58;
            Run(alarmclock, 13);

            // 5: Sets the time of an existing AC-obj to 6:12, the alarm to 6:15 and makes it run for 6 min. The code should indicate when the alarm is being triggered.
            ViewTestHeader("Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låter det gå 6 minuter.");
            alarmclock.Hour = 6;
            alarmclock.Minute = 12;
            alarmclock.AlarmHour = 6;
            alarmclock.AlarmMinute = 15;
            Run(alarmclock, 6);

            // 6: Test of the properties verifying exceptions being thrown when time/alarm is being assigned invalid values.
            ViewTestHeader("Test 6.\nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden.");

            try
            {
                alarmclock.Hour = 24;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock.Minute = 60;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock.AlarmHour = 50;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock.AlarmMinute = 100;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            Console.WriteLine();

            // 7: Test of constructors making sure exceptions are being thrown when time/alarm is being assigned invalid values.
            ViewTestHeader("Test 7.\nTestar konstruktorer så att undantag kastas då tid och alarmtid tilldelas \nfelaktiga värden.");
            
            try
            {
                alarmclock = new AlarmClock(24, 0);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock = new AlarmClock(0, 60);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock = new AlarmClock(0, 0, 50, 0);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarmclock = new AlarmClock(0, 0, 0, 100);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
        }

        // Method with 2 parameters.
        // 1st one: a reference to an AlarmClock object.
        // 2nd one: the amount of minutes an AC-obj should run (by letting an object make numerous calls to the TickTock-method through an iteration).
        private static void Run(AlarmClock ac, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════╗ ");
            Console.WriteLine(" ║      Väckarklockan URLED (TM)       ║ ");
            Console.Write(" ║       "); Console.ForegroundColor = ConsoleColor.Gray; Console.Write("Modellnr.: 1DV402S2L2A"); Console.ForegroundColor = ConsoleColor.White; Console.Write("        ║ \n");
            Console.WriteLine(" ╚═════════════════════════════════════╝ ");
            Console.ResetColor();

            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(string.Format(" ♫" + ac.ToString() + "   BEEP! BEEP! BEEP! BEEP!"));
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("  {0}", ac.ToString());
                }
            }
            Console.WriteLine();
        }

        // Method which receives an exception in form of an argument and presents it (the error messages from the tests). 
        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Method which receives a string as an argument and presents it (the headers of each test).
        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(HorizontalLine);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
