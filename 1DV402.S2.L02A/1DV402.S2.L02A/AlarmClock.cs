using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class AlarmClock
    {
        private int _alarmHour; // Private field that contains the value of the alarm hour. Encapsulated by the property "AlarmHour".
        private int _alarmMinute; // Contains the value of the alarm minute. Encapsulated by the property "AlarmMinute".
        private int _hour; // Contains the hour value of the current time. Encapsulated by "Hour".
        private int _minute; // Contains the minute value of the current time. Encapsulated by "Minute".

        // Property which encapsulates the private field "_alarmHour". The set method needs to verify that the value to be assigned to _alarmHour 
        // validates within the interval of 0-23. If out of the required interval - an ArgumentException should be thrown.
        // Same with props: AlarmMinute (0-59), Hour (0-23) and Minute (0-59).
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Alarmtimmen är inte i intervallet 0-23.");
                }
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Alarmminuten är inte i intervallet 0-59.");
                }
                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Timmen är inte i intervallet 0-23.");
                }
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte i intervallet 0-59.");
                }
                _minute = value;
            }
        }

        // 3 constructors which task is to verify that an "AlarmClock-object" is correctly initialized with valid values/field data.

        // The default constructor should initialize the fields with their default values.
        // However no assignment is allowed within its body, which also should be empty. Need to call the constructor with two parameters.
        public AlarmClock()
            : this(0, 0)
        {
            
        }

        // This constructor should enable an AlarmClock-object to be initialized with its hour and minute.
        // However no assignment is allowed within its body, which also should be empty. Need to call the constructor with four parameters.
        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {
            
        }

        // Finally, the constructor which enables an AlarmClock-object to be initialized with its time and time of the alarm, given within the parameters.
        // The only constructor where assigning values to the fields is allowed within its body.
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }
        
        // Method being called to make the clock turn one minute. If the new time complies to the time of the alarm, the method should return "true", otherwise "false".
        // Method is responsible for increasing the minute value by 1 and the value has to be within 0-59.
        // When the value reaches 0, the value of hour should increase by 1. Value of hours has to be within 0-23.
        // No "Console.Write(Line)'s" allowed in this method.
        public bool TickTock()
        {
            _minute++;

            if (_minute > 59)
            {
                _minute = 0; _hour++;

                if (_hour > 23)
                {
                    _hour = 0;
                }
            }
            
            if (_hour == _alarmHour && _minute == _alarmMinute)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // Method which task is to return a string representing the value of an instance of the AlarmClock class (an object).
        // In case the value of the hour is only ONE(1) integer/digit, it should be presented WITHOUT THE COMMENCING ZERO.
        // However if the minute value is just one digit - the commencing zero should be presented.
        // No "Console.Write(Line)'s" allowed in this method.
        public override string ToString()
        {
            return (string.Format("{0,3}:{1:d2} ({2}:{3:d2})", _hour, _minute, _alarmHour, _alarmMinute));
        }
    }
}
