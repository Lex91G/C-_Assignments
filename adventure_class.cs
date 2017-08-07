using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_If_else
{
    class adventure_class
    {
        private string readMainMenu;
        private string readSecondPlace;
        private string caseSwitch;
        private string lastLog;
        public adventure_class()
        {
        } 
            
        private void mainMenu()
        {
            Console.WriteLine("You wake up from your alarm clock you see its 6:10 in the morning do you wake up and go to class or go back to bed? \n 1 = Go to class \n 2 = Back to bed");
            readMainMenu = Console.ReadLine();
            if (readMainMenu == "1")
            {
                secondPlace();                
            }
            else
            {
                Console.WriteLine("Well enjoy your beauty sleep. You just wasted alot of money and time.");
                Console.ReadLine();
            }
            
    }
        private void secondPlace() {
            Console.WriteLine("Tired and all you get out of bed. You walk down the stairs and you see a ghost. what do you do. \n 1 = Fight \n 2 = Run");
            readSecondPlace = Console.ReadLine();
            if (readSecondPlace == "1")
            {
                ghostStrick();
            }
            else

                Console.WriteLine("You fell running away and died.");
            Console.ReadLine();
        }

        private void ghostStrick()
        {
            Console.WriteLine("You look around for a weapon and find a couple pick one to win the battle \n 1 = A gun. You could shoot it! \n 2 = A knife. Shank it \n 3 = A Baseball bat. Hit it out of the park \n 4 = Run away. You'll never win this fight \n 5 = Keep looking for weapons");
            caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":
                    Console.WriteLine("What you gonna do shoot a ghost. Game over");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Well we all know you cant stab a ghost. Game over");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You swung missed and fell down. Sorry Game over");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("You got to scared and fell down. Game over");
                    Console.ReadLine();

                    break;
                case "5":
                    Console.WriteLine("");
                    finalBattle();
                    break;
                default:
                    break;
            }

        }
        private void finalBattle()
        {
            Console.WriteLine("As you run away searching for something to use as a weapon he traps you. Now theres no escape \n 1 = Broom \n 2 = Vaccume \n 3 = Hide");
            lastLog = Console.ReadLine();
            switch (lastLog) {
                case "1":
                    Console.WriteLine("Clean that ghost up now hell never be dirty. you lose, Game over"); 
                    break;
                case "2":
                    Console.WriteLine("You vaccumed up the ghost. It became sunny outside and the birds were cherping. The things you do so you can make it to class everyday. You WIN.");
                break;
                case "3":
                    Console.WriteLine("The ghost found you. He seen where you hid. Game over");
                break;
            }
        }
        public void pullEverythingTogether()
        {
            mainMenu();            
        }
     }
 }
     
