using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
             var palindrome = new Palindrome();
            Console.WriteLine("Welcome the Palindrome World\n Please type a paragragh to check for palindromes.");
            //User Input
            var input = Console.ReadLine();
            // Check if input is not null
            if (input.Length > 0)
            {
                Console.WriteLine("Would you like to check for words containing a specific letter?\n Type: Y or N");
                var checkLetter = Console.ReadLine();

                if (checkLetter.ToLower() == "y")
                {
                    Console.WriteLine("Please type a letter A to Z!");
                    var letter = Console.ReadLine()[0];

                    //Check if is input is a letter
                    if (Char.IsLetter(letter))
                    {
                        palindrome.IsPalindrome(input, letter);
                    }
                    else
                    {
                        Console.WriteLine("Letter is invalid.");
                    }
                }
                else
                {
                    palindrome.IsPalindrome(input);
                }
            }
            else
            {
                Console.WriteLine("Empty paragraph is not supported.");
            }
        }
    }
}
