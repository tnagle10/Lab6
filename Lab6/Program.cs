using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {

        // Boolean variables for testing various sentence conditions
        static bool startsWithVowel(string input)
        {
            /* Name: startsWithVowel
            * Description:  This method returns true if the string starts with a vowel
            * Input:  String
            * Output: Returns true if string starts with a vowel.  Otherwise it returns false.
            */
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] letters = input.ToArray();

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == letters[0])
                {
                    return true;
                }
            }
            return false;
        }

        static bool startsWithACapital(string input)
        {

            /* Name: startsWithACapital
            * Description:  This method returns true if the string starts with a capital letter
            * Input:  String
            * Output: Returns true if string starts with a capital letter
            */
            char[] letters = input.ToArray();
            bool upper = char.IsUpper(letters[0]);
            return upper;
        }

        static bool allCaps(string input)
        {

            /* Name: allCaps
            * Description:  This method returns true if the string is all caps
            * Input:  String
            * Output: Returns true if string is all caps.  Otherwise it returns false.
            */
            char[] letters = input.ToArray();
            int capCount = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i]))
                {
                    capCount++;
                }
            }
            if (capCount == (letters.Length))
            { return true; }

            return false;
        }

        static bool containsNumbers(string input)
        {

            /* Name: containsNumbers
            * Description:  This method returns true if the string contains numbers
            * Input:  String
            * Output: Returns true if string contains a number.  Otherwise it returns false.
            */
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] letters = input.ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (letters[i] == numbers[j])
                    {

                        return true;
                    }
                }
            }

            return false;
        }

        static bool containsSympols(string input)
        {
            char[] numbers = { '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
            char[] letters = input.ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (letters[i] == numbers[j])
                    {

                        return true;
                    }
                }
            }

            return false;
        }

        static bool containsPunctuation(string input)
        {
            char[] punctuation = { '.', ',', '!' };
            char[] letters = input.ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < punctuation.Length; j++)
                {
                    if (letters[i] == punctuation[j])
                    {

                        return true;
                    }
                }
            }

            return false;
        }

        static bool keepGoing()
        {
            /* Name: keepGoing
            * Description:  This method implements a loop to determine if users wants to continue
            * Input:  None
            * Output: Returns false if user doesn't want to continue.  Otherwise returns true.
            *         Outputs values to Console
            */


            // If user enters "q", execute exit procedure
            Console.WriteLine("\nContinue? (y/n):");
            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("You entered n\n");
                Console.WriteLine("Are you sure you want to exit? (Type y to confirm)");
                input = Console.ReadLine();

                if (input == "y")
                {
                    return false;
                }

            }

            return true;
        }

        static string capitilizeFirst(string input)
        {
            /* Name: capitilizeFirst
            * Description:  This method returns a string with the first letter capitilized
            * Input:  String
            * Output: Returns a string with first letter capitilized
            */
            char[] letters = input.ToArray();
            string outWord = "";

            for (int i = 0; i < letters.Length; i++)
            {
                if (i == 0)
                {
                    char upper = char.ToUpper(letters[0]);
                    outWord = outWord + upper;
                }
                else
                {
                    outWord = outWord + letters[i];
                }

            }
            return outWord;

        }

        static string capitilizeAll(string input)
        {
            /* Name: capitilizeAll
            * Description:  This method returns a string with all the letters capitilized
            * Input:  String
            * Output: Returns a capitilized string
            */
            char[] letters = input.ToArray();
            string outWord = "";

            for (int i = 0; i < letters.Length; i++)
            {
                char upper = char.ToUpper(letters[i]);
                outWord = outWord + upper;
            }
            return outWord;

        }

        static char returnPunctuation(string input)
        {
            /* Name: returnPunctuation
            * Description:  This method will return the first punctuation character found in a string
            * Input:  String
            * Output: Returns a punctuation character if one is found
            */
            char[] punctuation = { '.', ',', '!' };
            char[] letters = input.ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < punctuation.Length; j++)
                {
                    if (letters[i] == punctuation[j])
                    {

                        return punctuation[j];
                    }
                }
            }

            return '0';
        }

        static string stripPunctuation(char punct, string input)
        {
            /* Name: stripPunctuation
            * Description:  This method will remove any character from a string that is input
            * Input:  String
            * Output: Returns a punctuation character if one is found
            */
            char[] letters = input.ToArray();
            string output = "";
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] != punct)
                {
                    output = output + letters[i];
                }
            }
            return output;
        }

        static int findFirstVowel(string input)
        {
            /* Name: findFirstVowel
            * Description:  This method will find the firt vowel it finds in a string and
            *               return its position in char array
            * Input:  String
            * Output: Returns a array location
            */
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] letters = input.ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (letters[i] == vowels[j])
                    {

                        return i;
                    }
                }
            }

            return 0;
        }

        static StringBuilder convToPig(string word)
        {
            /* Name: convToPig
            * Description:  This method converts a word into Pig Latin
            * Input:  String
            * Output: Returns a StringBuilder string with the rules of Pig Latin applied
            */

            // Starts with a vowel
            if (startsWithVowel(word))
            {
                StringBuilder vowelPig = new StringBuilder();
                vowelPig.Append(word);
                vowelPig.Append("way");
                return vowelPig;

            }

            // Starts with a consonant
            else
            {
                int firstVowel = findFirstVowel(word);
                string frontConsonants = word.Remove(firstVowel);
                string restofString = word.Substring(firstVowel);
                StringBuilder consonantPig = new StringBuilder();
                consonantPig.Append(restofString);
                consonantPig.Append(frontConsonants);
                consonantPig.Append("ay");
                //Console.WriteLine(consonantPig);
                return consonantPig;
            }
        }

        static void Main(string[] args)
        {
            do  // Loop while user continues
            {
                Console.WriteLine("Welcome to Pig Latin Translator.\nPlease enter a sentence to convert to pig latin: ");
                string inSentence = (Console.ReadLine());
                // Split sentence into words by spaces
                string[] words = inSentence.Split(' ');
                StringBuilder outSentence = new StringBuilder();
                StringBuilder convertedWord;


                // Loop for all the words in a sentence
                for (int i = 0; i < words.Length; i++)
                {
                    // Validate test conditions
                    bool caps = allCaps(words[i]);
                    bool numbers = containsNumbers(words[i]);
                    bool firstWord;
                    bool punctuation = containsPunctuation(words[i]);

                    // Test to see if first word in the sentence.  
                    if (i == 0)
                    {
                        firstWord = true;
                    }
                    else
                    {
                        firstWord = false;
                    }


                    Console.WriteLine("caps" + caps);
                    Console.WriteLine("numbers" + numbers);
                    Console.WriteLine("first word" + firstWord);
                    Console.WriteLine("punctuation" + punctuation);

                    // If word is a number, don't translate to Pig Latin
                    // And don't worry about punctuation
                    if (numbers)
                    {
                        outSentence.Append(words[i]);
                        outSentence.Append(" ");
                    }

                    // If word is a number with punctuation, strip puncuation
                    // and put it at the end.  Don't convert to Pig Latin
                    if (numbers && punctuation)
                       {

                            char punc = returnPunctuation(words[i]);
                            string stripped = stripPunctuation(punc, words[i]);
                            outSentence.Append(stripped);
                            outSentence.Append(punc);
                            outSentence.Append(" ");
                        }


                    // If punctuation and not the first word, strip off punctuation and add it to end
                    if (punctuation && !firstWord)
                    {
                        char punc = returnPunctuation(words[i]);
                        string stripped = stripPunctuation(punc, words[i]);
                        convertedWord = convToPig(stripped);
                        outSentence.Append(convertedWord);
                        outSentence.Append(punc);
                        outSentence.Append(" ");

                    }

                    // If punctuation and first word, strip off punctuation add it to the end.
                    // Also capitilize just the first letter of the sentence
                    if (punctuation && firstWord && !numbers)
                    {
                        char punc = returnPunctuation(words[i]);
                        string stripped = stripPunctuation(punc, words[i]);
                        string strippedLowered = stripped.ToLower();
                        convertedWord = convToPig(strippedLowered);
                        string convertedWordString = convertedWord.ToString();
                        convertedWordString = capitilizeFirst(convertedWordString);
                        outSentence.Append(convertedWordString);
                        outSentence.Append(punc);
                        outSentence.Append(" ");
                    }

                   


                    // If word is all caps, keep it all caps
                    if (caps)
                    {
                        convertedWord = convToPig(words[i]);
                        string convertedWordString = convertedWord.ToString();
                        convertedWordString = capitilizeAll(convertedWordString);
                        outSentence.Append(convertedWordString);
                        outSentence.Append(" ");
                    }


                    // If word is the first word in a sentecne and not all caps/numbers/punctuation, capitilize first letter of word
                    if (firstWord && !caps && !numbers && !punctuation)
                    {
                        words[0] = words[0].ToLower();
                        convertedWord = convToPig(words[0]);
                        string convertedWordString = convertedWord.ToString();
                        convertedWordString = capitilizeFirst(convertedWordString);
                        outSentence.Append(convertedWordString);
                        outSentence.Append(" ");
                    }

                    // If normal word convert to pig latin as normal
                    if (!firstWord && !caps && !numbers && !punctuation)
                    {
                        words[i] = words[i].ToLower();
                        convertedWord = convToPig(words[i]);
                        outSentence.Append(convertedWord);
                        outSentence.Append(" ");
                    }


                }

                // Print out completed sentence
                Console.WriteLine(outSentence);


            } while (keepGoing());

        }

    }
}

