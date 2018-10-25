using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay_Calculator
{
    class clockRadio
    {
        // number variables
        public string currentTime;
        public bool alarmStatus;
        public string alarmTime;
        public string radioStation;


        // constructor
        public clockRadio()
        {
            this.currentTime = "12:00 am";
            this.alarmTime = "6:00 am";

        }

        
        // member methods
        public void SetCurrentTime()
        {
            Console.WriteLine("Please enter the current time:");
            currentTime = Console.ReadLine();
        }
        public void ChangeAlarmTime()
        {

        }
        public void ChangeRadioStation()
        {

        }
        public void AlarmToggle()
        {

        }

    }
}
