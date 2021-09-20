using System;

namespace Assignment___Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman!");

            string secretWord = "Coding";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 10;
            bool outOfGuesses = false;
            char[] array1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            string[] randomWord = new string[5];
            randomWord[1] = "Hello";
            randomWord[2] = "Coding";
            randomWord[3] = "Computer";
            randomWord[4] = "Lexicon";
            randomWord[5] = "Console";


            while (guess != secretWord && !outOfGuesses && randomWord) 
            {
                if (guessCount < guessLimit) 
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outOfGuesses = true;
                }
               
            }
            if (outOfGuesses)
            {
                Console.Write("You failed to guess the word correctly!");
            }
            else 
            {
                Console.Write("You guessed the word right!");
            }  
        }      
    }
}
