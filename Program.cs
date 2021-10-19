using System;

namespace Randomenumbergen
{
    class Program
    {
        static void Main(string[] args){   
            Random numberGen = new Random();

            int computerNumber =  numberGen.Next(1,100);
            int attempts = 0;

            Console.WriteLine("I'm thinking of a number between 1-100, guess witch!");
            int playerGuess = 0;

            while (playerGuess != computerNumber) {
                playerGuess = Convert.ToInt32(Console.ReadLine());

                if (playerGuess > computerNumber) {
                    Console.WriteLine("Too high");

                } else if (playerGuess < computerNumber){
                    Console.WriteLine("Too low");
                }
                attempts ++; 
            }

            if (playerGuess == computerNumber) {
                Console.WriteLine("You got it right!");
                Console.WriteLine("My number was: " + computerNumber + " It took you " + attempts + " attempts to do it!");
            }

            Console.ReadKey(); 
                
             
        }
    }
}
