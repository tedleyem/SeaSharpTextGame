using System;
using System.Threading;

namespace TextGame
{
    class Program
    {
        int choice;
        static void Main(string[] args)
        {
            Console.WriteLine(Style.introText);
            Console.WriteLine("                           by Yahoo Silverman");
            Thread.Sleep(2000); //Thread delays the output, it's better this way.
            Console.WriteLine("I want to flesh out my Github so enjoy this flesh...");
            Thread.Sleep(2000);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");

            Character.characterBuild();

            Console.WriteLine("Your journey begins. I have not written a story...");
            Thread.Sleep(2000);
            Console.WriteLine("Just want wanna make the red squiggly lines in my code dissapear");
            Thread.Sleep(3000);
            Console.WriteLine("WAIT LOOK A CHALLENGER (theme song plays)");
            Thread.Sleep(2000);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------------");
            Battle.battleSystem();



        }

    }
}


       
       
            
        

