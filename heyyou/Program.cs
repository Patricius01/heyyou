using System;

namespace heyyou
{
    class Program
    {
        static void Main(string[] args)
        {
            // When program starts
            Console.WriteLine("Hello World!");



            // Greet the user and ask them to input their name
            Console.WriteLine("Hello New User - What is your name?");

            // Create a string variable for the user's name,
            // then take the data input by the keyboard (by the user),
            // then store the input data (the user's name) inside of the variable (userName)!
            string userName = Console.ReadLine();

            // Now, greet the user using their name
            Console.WriteLine("Hello, " + userName + "!");



            // Ask the user a question
            Console.WriteLine("Are you having a good day?");

            // Create another string variable to store the user's answer
            string goodDay = Console.ReadLine();

            // Define likely positive answers
            string answerOne = "yes";
            string answerTwo = "Yes";
            
            // Give a response based upon whether or not the user's answer is equal to either of the likely positive answers
            if ((goodDay == answerOne) || (goodDay == answerTwo))
            {
                Console.WriteLine("Smashing! I'm happy to hear that!");
            }
            else
            {
                Console.WriteLine("Perhaps a glass of water and a 10-minute meditation may lift your mood! See you back here in 15?");
            }
        }
    }
}
