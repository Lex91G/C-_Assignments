using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ClockRadio
    {
        //member variables
        private bool isOn;
        private string alarmClock;
        private string radioStation;

        //constuctor
        public ClockRadio()
        {

        }

        //member methods
        private void TurnOnOff()
       {
            if (isOn == true)
            {
                isOn = false;
                Console.WriteLine("You have turned the radio off.");
                // return false;
            }
            else
            {
                isOn = true;
                Console.WriteLine("You have turned the radio on.");
                // Console.ReadLine();
                // return true;
            }                           
        }

        private void setAlarm()
        {
            Console.WriteLine("Set Alarm \n ");
              alarmClock = Console.ReadLine();
            Console.WriteLine("Your Alarm will go off at " + alarmClock);
        }
        private void setStation()
            {
            Console.WriteLine("Choose a radio station \n ");
            radioStation = Console.ReadLine();
            Console.WriteLine("Station set to:  " + radioStation);
            Console.ReadLine();
        }

        public void joinAll()
        {
            TurnOnOff();
            setAlarm();
            setStation();
            
            
                
        }      
        }

    }


