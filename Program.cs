using System;

namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logic and Loops!\n");

            //Variables
            string playerName = "adventurer"; //init default value

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
                "To your right, you see a cave. With night coming quickly, you can sleep in comfort and protection. But you won't be closer to finding your way home.\n");
        }
    }
}