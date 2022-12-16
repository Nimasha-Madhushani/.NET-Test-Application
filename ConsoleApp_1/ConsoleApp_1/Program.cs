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
            //run GetInfo function
            GetAppInfo();

            //greet user
            GreetUser();
            while (true)
            {
                //init correct number
                //int correctNum = 4;

                //create new random object
                Random random = new Random();

                //init correct number
                int correctNum = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNum)
                {
                    //get user input
                    string inputnum = Console.ReadLine();

                    //make sure it is a number
                    if (!int.TryParse(inputnum, out correctNum))
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep gonig
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(inputnum);

                    //match guess to correct number
                    if (guess != correctNum)
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");

        
                    }
                }

                //Print error message
                PrintColorMessage(ConsoleColor.Yellow, "you are corrrect");


                //ask to play again
                Console.WriteLine("Play again, Y or N?");

                //get answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }



            }
        
        }
        static void GetAppInfo()
        {
          //string name = "Bad boy";
            //t age = 20;
            //start here//

            //Csole.WriteLine(name + " is " + age);
           //onsole.WriteLine("{0} is {1}", name, age);

            //set app vars
            string appName = "Program";
            string appVersion = "1.0.0";
            string appAuthor = "Nimasha ";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //write out app info
            Console.WriteLine("{0}:Vrsion {1} by {2}", appName, appVersion, appAuthor);

            //reset color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game", input);

        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;


            //tell user it's wrong
            Console.WriteLine(message);

            //reset color
            Console.ResetColor();
        }
    }
}