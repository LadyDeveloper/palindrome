using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace palindrome
{
    public class Palindrome
    {
        public void IsPalindrome(string paragraph, char letter = default)
        {
            int countWord = 0;
            int countSentence = 0;
            var uniqueWord = new List<string>();
            var listWords = new List<string>();


            // Check if a word is a palindrome
            foreach (var word in paragraph.Split(" "))
            {
                var wordReplaced = Regex.Replace(word, "[^a-zA-Z_]+", "").ToLower();

                if (CheckForPalindromes(wordReplaced))
                {
                    countWord++;
                }

                if (!uniqueWord.Contains(wordReplaced))
                {
                    uniqueWord.Add(word);
                }

                if (!Char.IsDigit(letter) && wordReplaced.Contains(letter))
                {
                    listWords.Add(word);
                }
            }

            // Check paragraph
            //Considering that a sentence ends with one of these characters {'!', '.', '?'}
            char[] sentenceSeparators = { '!', '.', '?' };
            foreach (var sentence in paragraph.Split(sentenceSeparators))
            {
                var sentenceReplaced = Regex.Replace(sentence, "[^a-zA-Z_]+", "").ToLower();

                if (CheckForPalindromes(sentenceReplaced))
                {
                    countSentence++;
                }
            }

            Console.WriteLine("Number of palindrome words: {0}", countWord);
            Console.WriteLine("Number of palindrome sentences: {0}", countSentence);
            Console.WriteLine("List of unique words: {0}", string.Join(", ", uniqueWord));

            if(!Char.IsDigit(letter))
            {
                if(listWords.Count > 0)
                {
                    Console.WriteLine("Found {0} words with {1} : {2}",listWords.Count , letter, string.Join(", ", listWords));
                }
                else
                {
                    Console.WriteLine("No words with {0} letter.", letter);
                }

            }
            

        }

        public static bool CheckForPalindromes(string word)
        {
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);

            return word.Equals(reversedWord, StringComparison.Ordinal);
        }

    }
}