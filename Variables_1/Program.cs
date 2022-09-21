using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studioName; // Declare "studioName"
            studioName = "Dreadnought Studio"; // Init. "studioName" to be Dreadnought Studio 
            Console.WriteLine("Brought to you by: " + studioName); // Display text plus "studioName"
            Console.WriteLine("");

            string gameName; // Declare "gameName"
            gameName = "Totally Real RPG"; // Init. "gameName" to be Totally Real RPG
            Console.WriteLine(" {" + gameName + "} ");
            Console.WriteLine("");

            Console.ReadKey(true);
            Console.Clear(); // clears the text the user/player sees from the display

            // Declareing Values
            int health;
            int scoreCoin;
            int lives;
            int hardCodedMoneyValue;
            float scoreMultiplier;
            float deadValue;
            int result;

            // Initialized Values
            health = 100;
            scoreCoin = 0;
            lives = 1;
            hardCodedMoneyValue = 5;
            scoreMultiplier = 4.0f;
            deadValue = -1.0f;
            result = 0;

            //game start
            Console.WriteLine("Game Starts Now!!!");
            Console.WriteLine("");
            Console.WriteLine("well... after you press a Key.");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives.");
            Console.WriteLine("looks like you only live once, YOLO!!!");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("You should get some money!!");
            Console.WriteLine("");
            Console.WriteLine("I can give you 4x the amount of money you get.");
            Console.WriteLine("");
            Console.WriteLine("press any Key to accept.");

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            result = (int)(hardCodedMoneyValue * scoreMultiplier);
            scoreCoin = scoreCoin + result;
            health = health - result;
            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            result = (int)(hardCodedMoneyValue * scoreMultiplier);
            scoreCoin = scoreCoin + result;
            health = health - result;
            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            result = (int)(hardCodedMoneyValue * scoreMultiplier);
            scoreCoin = scoreCoin + result;
            health = health - result;
            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            result = (int)(hardCodedMoneyValue * scoreMultiplier);
            scoreCoin = scoreCoin + result;
            health = health - result;
            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            result = (int)(hardCodedMoneyValue * scoreMultiplier);
            scoreCoin = scoreCoin + result;
            health = health - result;
            Console.WriteLine("You have " + health + "% Health.");
            Console.WriteLine("");
            Console.WriteLine("You have " + lives + " lives left");
            Console.WriteLine("");
            Console.WriteLine("You have $" + scoreCoin + ".00 in your wallet.");
            Console.WriteLine("");
            Console.WriteLine("Oh look you found $5.00 press any Key to take it");

            Console.ReadKey(true);
            Console.Clear();

            if(health == 0)
            {
                lives = (int)(lives + deadValue);
                Console.WriteLine("You have " + health + "% Health.");
                Console.WriteLine("");
                Console.WriteLine("You have " + lives + " lives left");
                Console.WriteLine("");
                Console.WriteLine("YOU DIED!!!");
                Console.WriteLine("I Forgot to tell you that you die after you get $100.");
            }

            Console.ReadKey(true);
        }
    }
}
