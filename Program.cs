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
            //Console.WriteLine(playerName + ", huh?...What a nice name :)\n");

            //Continue the story
            Console.WriteLine("" +
                "You walk forward and find yourself at the intersection of two paths: \n" +
                "\nTo your left, the setting sun illuminates a trail marker. Going west will certainly lead you to other people. But you don't know who awaits you.\n" +
                "To your right, you see a cave. With night coming quickly, you can sleep in comfort and protection if only you go east. But you won't be closer to finding your way home.");

            //Ask player to choose path
            Console.WriteLine("Which direction will you go?");
            Console.WriteLine("\n[Type 'left' to go left, 'right' to go right, or 'again' to see your options again]");

            //Grab more user input
            userChoice = Console.ReadLine();
            InitialChoice();
            void InitialChoice()
            {
                //Select our path
                if (userChoice == "left")
                {
                    //Console.WriteLine("You chose: " + userChoice);
                    Console.WriteLine("\nYou go left and find a small village. The strangers are kind to you. You don't feel alone anymore.");
                    Console.WriteLine("\"Community\" - Ending 1/???");
                }
                else if (userChoice == "right")
                {
                    //Console.WriteLine("You chose: " + userChoice);
                    Console.WriteLine("\nYou go right and prepare to spend the night in the cave. It's secure and secluded. No one will bother you here.");
                    Console.WriteLine("\"Protection\" - Ending 2/???");
                }
                else if (userChoice == "again")
                {
                    ChooseAgain(RepeatOptions());
                }
                else
                {
                    //user typed in something else
                    Console.WriteLine("\n\"" + userChoice + "\" is not a choice you have.");
                    userChoice = PseudoRepeat();
                    InitialChoice();
                }
            }
            static string PseudoRepeat()
            {
                string choice = Console.ReadLine();
                return choice;
            }
            /*
             * If user picks 'again'
             * RepeatOptions will call on ChooseAgain
             */
            static string RepeatOptions()
            {
                Console.WriteLine("\n" +
                    "The setting sun illuminates a trail marker.\n" +
                    "There's a cave is shrouded in darkness.\n");

                Console.WriteLine("[Type 'left' to 'right' or 'again' but are those the only options]");

                //Returns "userChoice" value with local var
                string repeatedChoice = Console.ReadLine();
                return repeatedChoice;
            }

            void ChooseAgain(string pick)
            {
                userChoice = pick;
                //Select our path
                if (userChoice == "left")
                {
                    Console.WriteLine("\nYou follow the trail to completion, there are no more signs.\nBut the writing is pristine, these must have been put here recently.\nA person put this here, no doubt about it.\nAnd yet you're still alone.");
                    Console.WriteLine("\n\"Isolation\" - Ending 3/5");

                }
                else if (userChoice == "right")
                {
                    Console.WriteLine("\nYou walk into the cave, only to find the darkness give way.\nYour eyes hurt from artificial LED light.\nYou thought you were safe from it, you should have been safe from it.\nBut it's too late.\nNow you'll never be alone.");
                    Console.WriteLine("\n\"Exposure\" - Ending 4/5");
                }
                else if (userChoice == "down")
                {
                    Console.WriteLine("\nYou try to go down, but Hell is just out of reach.");
                    userChoice = Console.ReadLine();
                    ChooseAgain(userChoice);
                }
                else if (userChoice == "back")
                {
                    Console.WriteLine("...\n\n\n\n\n\n\n\n\n\n...but it's not yours anymore.");
                }
                else if (userChoice == "up")
                {
                    Console.WriteLine("\nYou try to go up, but Heaven is a little higher than your vertical.");
                    userChoice = Console.ReadLine();
                    ChooseAgain(userChoice);
                }
                else if (userChoice == "forward")
                {
                    //true ending, you go forward and find your name that they took from you
                    //Console.WriteLine("You chose: " + userChoice);
                    Console.WriteLine("\nThere's a lake in front of you.\nYou don't understand how you didn't notice it before.\nWhen you look in the water, you see someone.\nYou call out their name:");
                    userChoice = Console.ReadLine();
                    if (userChoice == playerName)
                    {
                        Console.WriteLine("\nAnd you smile at your reflection.\nIt's you, " + playerName + ".\nOf course it is.\nThat's all it needed to be.");
                        Console.WriteLine("\"Identity\" - True Ending");
                    } else
                    {
                        Console.WriteLine("\nNo sound comes out.\nAs you are pulled into the water, your heart beats faster, wasting precious oxygen.\nBut when you scream for help, all you hear is the sound of waves.");
                        Console.WriteLine("\"Obscurity\" - Ending 5/5");
                    }
                    
                }
                else if (userChoice == "again")
                {
                    userChoice = Console.ReadLine();
                    ChooseAgain(userChoice);
                }
                else
                {
                    //user typed in something else
                    Console.WriteLine("\n\"" + userChoice + "\" is not a choice you have.");
                    userChoice = Console.ReadLine();
                    ChooseAgain(userChoice);
                }
            }
        }
    }
}