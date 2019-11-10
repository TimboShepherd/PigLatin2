using System;

namespace PigLatin
{
    class Program
    {
        private const string Vowals = "AEIOU";

        static void Main(string[] args)
        {
            // get some input
            Console.WriteLine("Please enter a sentence:");
            var userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("You didn't type nothing!");
            }

            // work out if there is a word, or a sentence
            // sentence will have multiple words
            var parsedWordArray = userInput.Split(' ');

            Console.WriteLine("");
            Console.WriteLine("Converted text:");
            if (parsedWordArray.Length > 1)
            {
                Console.WriteLine(TranslateSentence(userInput));
            }
            else
            {
                Console.WriteLine(TranslateWord(userInput));
            }

            Console.ReadLine();


            

            string TranslateWord(string word)
            {
                var result = "";
                
                var wordLength = word.Length;

                // get letter 1 - check for consonant
                var letter1 = word[0].ToString();
                if (Vowals.Contains(letter1))
                {
                    // This is easy - add "yay" to the end
                    result = string.Concat(word, "yay");
                }
                else
                {
                    // need to find the first vowal, and move the letters to the back and add "ay"
                    var i = 0;
                    var lettersToMove = "";
                    foreach (char letterChar in word)
                    {
                        var letter = letterChar.ToString();
                        if (Vowals.Contains(letter.ToUpper())) break;

                        lettersToMove += letter;
                        i += 1;
                    }

                    result = word.Replace(lettersToMove, "");

                    result = result + lettersToMove + "ay";

                    // herer are some changes

                }






                return result;
            }

            string TranslateSentence(string sentence)
            {
                return "";
            }

        }
        
    }

}
