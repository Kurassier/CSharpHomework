using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class Alarm
    {
        public delegate void TimerEventHandler();
        public event TimerEventHandler timeUp;

        DateTime alarm;

        public void SetAlarm(int hour, int minute, int second)
        {
            alarm = DateTime.Now.AddHours(hour).AddMinutes(minute).AddSeconds(second);
            timeUp += Print;
        }
        public void RunAlarm()
        {
            while (alarm > DateTime.Now)
            {
                System.Threading.Thread.Sleep(500);
            }
            if (timeUp != null)
            {
                timeUp();
            }
        }
        private void Print()
        {
            Console.WriteLine("Time Up!");
        }
    }
}
