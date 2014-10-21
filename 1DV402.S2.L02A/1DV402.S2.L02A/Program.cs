using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class Program
    {
        /// <summary>
        /// This class is responsible for testing the AlarmClock class, verifying that its members have been correctly implemented 
        /// by running a total of 7 tests, in which different AlarmClock-objects are being instantiated and used to test the constructors, 
        /// properties and methods respectively. Furthermore, the class will also present the results of the tests, including any potential 
        /// error messages being thrown.
        /// </summary>

        private static string HorizontalLine = "═══════════════════════════════════════════════════════════════════════════════";
        
        private static void Main(string[] args)
        {
            Console.Title = "Digital Väckarklocka - Nivå A";

            ViewTestHeader("Test 1.\nTest av standardkonstruktorn.");
            AlarmClock alarmclock = new AlarmClock();
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();
        
            ViewTestHeader("Test 2.\nTest av konstruktorn med två parametrar, (9, 42).");
            alarmclock = new AlarmClock(9, 42);
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();

            ViewTestHeader("Test 3.\nTest av konstruktorn med fyra parametrar, (13, 24, 7, 35).");
            alarmclock = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(alarmclock.ToString());
            Console.WriteLine();

            ViewTestHeader("Test 4.\nStäller befintligt AlarmClock-objekt till 23:58 och låter det gå 13 minuter.");
            alarmclock.Hour = 23;
            alarmclock.Minute = 58;
            Run(alarmclock, 13);

            ViewTestHeader("Test 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 \noch låter det gå 6 minuter.");
            alarmclock.Hour = 6;
            alarmclock.Minute = 12;
            alarmclock.AlarmHour = 6;
            alarmclock.AlarmMinute = 15;
            Run(alarmclock, 6);
            
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

        private static void Run(AlarmClock ac, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════╗ ");
            Console.WriteLine(" ║      Väckarklockan URLED (TM)       ║ ");
            Console.Write(" ║       "); 
            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.Write("Modellnr.: 1DV402S2L2A"); 
            Console.ForegroundColor = ConsoleColor.White; 
            Console.Write("        ║ \n");
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

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

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
