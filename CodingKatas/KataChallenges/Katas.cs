using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataChallenges
{
    public class Katas
    {

        public static int FilterString(string s)
        {
            //Your code goes here
            int x = 0;
            string result="";


            foreach (var i in s)
            {
                if (int.TryParse(i.ToString(), out x))
                {
                    result += i.ToString();
                }
            }

            int asNum = int.Parse(result);
            return asNum;
        }

        public static int Factorial(int n)
        {
            //In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.
            //Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java).
            //what is n -- count down from n, multiplying each time.
            int result = 1;

            if (n < 0 || n > 13)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (var i = n; i > 0; i--)
            {
                result = result*i;
            }

            return result;
        }

        public static string Swap(string str)
        {
            //Given a string, swap the case for each of the letters. e.g. CodEwArs --> cODeWaRS
            var newString = "";

            foreach (var i in str)
            {
                if (char.IsLower(i))
                {
                    newString += char.ToUpper(i);
                }
                else
                {
                    newString += char.ToLower(i);
                }
            }

            return newString;

        }

        public static string OddLadder(int n)
        {
            //You have to write a function pattern which creates the following pattern (see examples) up to the desired number of rows.
            //If the Argument is 0 or a Negative Integer then it should return "" i.e. empty string.
            //If any even number is passed as argument then the pattern should last upto the largest odd number which is smaller than the passed even number.
            int counter = 0;
            int num = 0;
            string result = "";

            if(n <= 0)
                return result;

            while (counter < n)
            {
                while (num >= counter)
                {
                    result += (counter+1).ToString();
                    num --;
                }
                
                counter+=2;
                num =counter*2;

                if  ((counter != n) && counter != n + 1)
                {
                    result += "\n";

                }
            }

            return result;
        }

        public static int GetMissingElement(int[] superImportantArray)
        {
            //  Our array, superImportantArray, was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

            //Write a function called getMissingElement that accepts an array of unique integers between 0 and 9 (inclusive), and returns the missing element.

            //Examples:

            //Kata.GetMissingElement( [0, 5, 1, 3, 2, 9, 7, 6, 4] ); // returns 8
            //Kata.GetMissingElement( [9, 2, 4, 5, 7, 0, 8, 6, 1] ); // returns 3

            //go through each number in array. check if it equal

            int[] num0to9 = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var foundNum = -1;

            foreach (var i in num0to9)
            {
                if (!superImportantArray.Contains(i))
                {
                    foundNum = i;
                }

            }
            return foundNum;
        }

        public static string MakeBackronym(string s)
        {
           Dictionary<char,string> dict = new Dictionary<char, string>();
           dict.Add('A', "awesome");
           dict.Add('B', "boy");
           dict.Add('C', "awesome");

            return dict['A']; // "awesome"

                //            Definition-

                //back·ro·nym

                //noun

                //a fanciful expansion of an existing acronym or word, such as “port out, starboard home” for posh.

                //You will create a function called makeBackronym . There will be a preloaded dictionary to use. The dictionary is an object where the the keys are letters A-Z and the values are a predetermined word.

                //Use the variable name (its name is written in the code template) to reference the uppercase letters of the dictionary.

                //EXAMPLE:

                //dict['P']=="perfect"
                       }
    }
}
