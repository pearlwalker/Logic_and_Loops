using System;

namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logic and Loops!\n");

            //Variables
            string playerName = "adventurer"; //initialize to generic "adventurer" valie
            string userChoice = "NONE";
            bool navigator = false; //if player answers path with cardinal direction not left/right

            //Start program
            Console.Write("Here at 'Logic and Loops', we have some fun\nWe like telling stories,\nExploring worlds of wonder,\nAnd, of course, taking names.\n\n");
            Console.WriteLine("But it seems we don't have your name!");
            Console.WriteLine("Can you give us your name?");
            Console.WriteLine("[Enter your name, then press 'ENTER' on the keyboard]\n");

            //Grab some user input
            playerName = Console.ReadLine();
            Console.WriteLine(playerName+ ", huh?...What a nice name :)\n");

            //Continue the story
            Console.WriteLine("" +
                "You see a clearing up ahead\n" + 
                "You walk forward and find yourself at the intersection of two paths: \n" +
                "To your left, the setting sun illuminates a trail marker. Going west will certainly lead you to other people. But you don't know who awaits you.\n"+
                "To your right, you see a cave. With night coming quickly, you can sleep in comfort and protection if only you go east. But you won't be closer to finding your way home.\n");

            //Ask player to choose path
            Console.WriteLine("Which direction will you go?");
            Console.WriteLine("[Type your direction using lowercase letters]\n");

            //Grab more user input
            userChoice = Console.ReadLine();
            Console.WriteLine("You chose: " + userChoice);

            //Select our path
            if (userChoice == "left" || userChoice == "west")
            {
                //go left
                if (userChoice == "west")
                {
                    navigator = true;
                }
            } else if (userChoice == "right" || userChoice == "east")
            {
                //go right
                if (userChoice == "east")
                {
                    navigator = true;
                }
            } else if (userChoice == "down")
            {
                //try to dig down
                Console.WriteLine("You try to go down, but Hell is just out of reach. Don't worry, you'll get there eventually!");
            } else if (userChoice == "back" || userChoice == "south")
            {
                //start program over? or say they go then come back
            } else if (userChoice == "up")
            {
                //you hop but land on the same ground
                Console.WriteLine("You try to go up, but Heaven is a little higher than your vertical.");
            } else if (userChoice == "forward" || userChoice == "north")
            {
                //true ending, you go forward and find your name that they took from you
            } else
            {
                //user typed in something else
            }

        static void PathChoice(string choice, bool nav)
            {
                            //Continue the story
            Console.WriteLine("" +
                "You see a clearing up ahead\n" + 
                "You walk forward and find yourself at the intersection of two paths: \n" +
                "To your left, the setting sun illuminates a trail marker. Going west will certainly lead you to other people. But you don't know who awaits you.\n"+
                "To your right, you see a cave. With night coming quickly, you can sleep in comfort and protection if only you go east. But you won't be closer to finding your way home.\n");

            //Ask player to choose path
            Console.WriteLine("Which direction will you go?");
            Console.WriteLine("[Type your direction using lowercase letters]\n");

            //Grab more user input
            choice = Console.ReadLine();
            Console.WriteLine("You chose: " + choice);

            //Select our path
            if (choice == "left" || choice == "west")
            {
                //go left
                if (choice == "west")
                {
                    nav = true;
                }
            } else if (choice == "right" || choice == "east")
            {
                //go right
                if (choice == "east")
                {
                    nav = true;
                }
            } else if (choice == "down")
            {
                //try to dig down
                Console.WriteLine("You try to go down, but Hell is just out of reach. Don't worry, you'll get there eventually!");
            } else if (choice == "back" || choice == "south")
            {
                //start program over? or say they go then come back
            } else if (choice == "up")
            {
                //you hop but land on the same ground
                Console.WriteLine("You try to go up, but Heaven is a little higher than your vertical.");
            } else if (choice == "forward" || choice == "north")
            {
                //true ending, you go forward and find your name that they took from you
            } else
            {
                //user typed in something else
            }
            }
        }
    }
}