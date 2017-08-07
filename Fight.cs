using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot.main
{
    class Fight
    {
        public string getFightStarted;
        public int numberOfFighters;
        public int goodGuyNewHealth;
        public int badGuyNewHealth;
        // member variables

        // constructor
        public Fight()
        {

        }

        // member methods

        public void pickToFight()
        {
            Console.WriteLine("Welcome to fight club. First rule of fight club is not to talk about fight club. Would you like to enter your robot into a fight\n 1 = Yes \n 2 = No");
            getFightStarted = Console.ReadLine();
            if (getFightStarted == "1")
            {
                mainMenu();
            }
        }
        public void mainMenu()
        {
            Console.WriteLine("How many people would you like your robot to fight? \n Max amount allowed 5");
            numberOfFighters = Convert.ToInt32(Console.ReadLine());
            
        }
        public void fightNight(Robot GoodGuy, List<Robot> BadGuys)
        {
            for (int i = 0; i <= numberOfFighters; i++)
            {
                DoFight(GoodGuy, BadGuys[i]);
                if (goodGuyNewHealth <= 0)
                {
                    break;
                }
            }
        }

        public void DoFight(Robot bot1, Robot bot2)
        {
            
            goodGuyNewHealth = bot1.health - bot2.damage;
            badGuyNewHealth = bot2.health - bot1.damage;

            bot1.health -= bot2.damage;
            bot2.health -= bot2.damage;

            if (goodGuyNewHealth <= 0)
            {
                Console.WriteLine("You Lose!");
                Console.ReadLine();
            }
            else if (badGuyNewHealth <= 0)
            {
                Console.WriteLine("Next opponent");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(bot1.name + " current Health: " + bot1.health + "\n" + bot2.name + " current Health: " + bot2.health);
                Console.ReadLine();

                DoFight (bot1, bot2);
            }
        }

        public void Battle(Robot robotOne, List<Robot> badGuysBots)
        {

            fightNight(robotOne, badGuysBots);
        }
    }

}