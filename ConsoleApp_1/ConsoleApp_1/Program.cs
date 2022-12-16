using System;

//namespace
namespace TestProject1
{
    //Main Class
    class Tests
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            string name = "Bad boy";
            int age = 20;
            //start here//

            Console.WriteLine(name+" is "+age);
            Console.WriteLine("{0} is {1}",name,age);

            //set app vars
            string appName = "Program";
            string appVersion = "1.0.0";
            string appAuthor = "Nimasha ";

            //change text color
            Console.ForegroundColor= ConsoleColor.Green;


            //write out app info
            Console.WriteLine("{0}:Vrsion {1} by {2}",appName,appVersion,appAuthor);

           //reset color
            Console.ResetColor();

            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string input=Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game",input);

            //init correct number
            int correctNum = 4;

            //init guess var
            int guess = 0;

            //ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNum)
            {
                //get user input
                string inputnum = Console.ReadLine();

                //cast to int and put in guess
                guess=Int32.Parse(inputnum);

                //match guess to correct number
                if (guess != correctNum)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;


                    //write out app info
                    Console.WriteLine("Wrong number, try again");

                    //reset color
                    Console.ResetColor();
                }
            }

        }
    }
}