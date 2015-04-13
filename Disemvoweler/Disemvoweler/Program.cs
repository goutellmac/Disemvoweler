using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band.  Their songwriting can't be beat!");
            // keep the console open
            Console.ReadKey();
        }
        public static string Disemvoweler(string input)
        {
            //declare new string builders for the two returned strings
            System.Text.StringBuilder DisemvoweledString = new System.Text.StringBuilder();
            System.Text.StringBuilder VowelsRemovedString = new System.Text.StringBuilder();
            
            //for loop to look at each index point in the input string
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u' || input[i] == 'o' ||
                    input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'U' || input[i] == 'O')
                {
                    VowelsRemovedString.Append(input[i]);
                }
                else if (input[i] == 'b' || input[i] == 'c' || input[i] == 'd' || input[i] == 'f' || input[i] == 'g' || input[i] == 'h' || input[i] == 'j' ||
                    input[i] == 'k' || input[i] == 'l' || input[i] == 'm' || input[i] == 'n' || input[i] == 'p' || input[i] == 'q' || input[i] == 'r' ||
                    input[i] == 's' || input[i] == 't' || input[i] == 'v' || input[i] == 'w' || input[i] == 'x' || input[i] == 'y' || input[i] == 'z' ||
                    input[i] == 'B' || input[i] == 'C' || input[i] == 'D' || input[i] == 'F' || input[i] == 'G' || input[i] == 'H' || input[i] == 'J' ||
                    input[i] == 'K' || input[i] == 'L' || input[i] == 'M' || input[i] == 'N' || input[i] == 'P' || input[i] == 'Q' || input[i] == 'R' ||
                    input[i] == 'S' || input[i] == 'T' || input[i] == 'V' || input[i] == 'W' || input[i] == 'X' || input[i] == 'Y' || input[i] == 'Z')
                {
                    DisemvoweledString.Append(input[i]);
                }
 

            }
            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + DisemvoweledString);
            Console.WriteLine("Vowels Removed: " + VowelsRemovedString); 
            
         
            // Return the Disemvoweled string as well for testing
            return DisemvoweledString.ToString(); ;
        }
    }
}
