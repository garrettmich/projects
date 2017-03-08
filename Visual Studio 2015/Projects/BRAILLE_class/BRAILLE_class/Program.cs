using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Scratch3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up dictionary structure with top, middle, bottom
            Dictionary<char, string[]> brailleForChar = new Dictionary<char, string[]>()
            {
                { 'b', new string[] { "10", "10", "00", "b " } },
                { 'o', new string[] { "10", "01", "10", "o " } },
                { ' ', new string[] { " ",  " ",  " ",  " "  } }
            };

            // get the string
            Console.WriteLine("Please enter some words for me to convert to Braille");
            string alphabeticInput = Console.ReadLine();

            // check the input
            bool validInput = isInputValid(alphabeticInput, brailleForChar);
            for (int i = 0; i < alphabeticInput.Length; i++)
            {
                if (!brailleForChar.ContainsKey(alphabeticInput[i]))
                {
                    validInput = false;
                    // give feedback to user
                    Console.WriteLine("I don't know the letter " + alphabeticInput[i]);
                }
            }

            // figure out how many letters we can print on one line
            int maxWidthPerChar = 2;
            int widthInChars = Console.WindowWidth / maxWidthPerChar;
            //figure out how many lines we have to print
            //decimal outputLines = Math.Ceiling(Convert.ToDecimal(alphabeticInput.Length) / widthInChars);

            if (validInput)
            {
                // for each widthInChars chunk of the string
                while (alphabeticInput.Length > 0)
                {
                    // yank off a chunk
                    string currentChunk;
                    if (alphabeticInput.Length > widthInChars)
                    {
                        currentChunk = alphabeticInput.Substring(0, widthInChars);
                        alphabeticInput = alphabeticInput.Substring(widthInChars);
                    }
                    else //last chunk!
                    {
                        currentChunk = alphabeticInput;
                        alphabeticInput = "";
                    }
                    // iterate through the letters in a chunk, print each line
                    int heightOfBraille = 4;
                    for (int lineNumber = 0; lineNumber < heightOfBraille; lineNumber++)
                    {
                        for (int i = 0; i < currentChunk.Length; i++)
                        {
                            Console.Write(brailleForChar[currentChunk[i]][lineNumber]);
                        }
                        // newline
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Your input was invalid, I could not convert it.");
            }
            Console.ReadLine();
        }
    }
}