using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L02A
{
    class AlarmClock
    {
        /// <summary>
        /// Class verifying that an "AlarmClock-object" is correctly initialized with valid values, making the clock turn one minute (whilst checking if the new time
        /// complies to the time of the alarm) and returns a string-representation of an AlarmClock instance.
        /// </summary>
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

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

        public AlarmClock()
            : this(0, 0)
        {
            
        }

        public AlarmClock(int hour, int minute)
            : this(hour, minute, 0, 0)
        {
            
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }
        
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
        
        public override string ToString()
        {
            return (string.Format("{0,3}:{1:d2} ({2}:{3:d2})", _hour, _minute, _alarmHour, _alarmMinute));
        }
    }
}
