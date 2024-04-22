using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Check
{
    public class Palindrome_Check
    {
        public char[] charArr { get; set; }
        public char[] strToArray(string input)
        {
            // check for null or empty string
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("input", "Input cannot be null or empty");
            }

            // create a hashset containing all the special characters
            HashSet<char> specialChars = new HashSet<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/', '`', '~', ' ' };

            // input no uppercase
            input = input.ToLower();

            // remove all special characters from the string using the hashset
            if(input.Any(c => specialChars.Contains(c)))
            {
                input = new string(input.Where(c => !specialChars.Contains(c)).ToArray());
            }

            // convert string to char array
            charArr = input.ToCharArray();

            // return char array
            return charArr;

        }

        public bool isPalindrome()
        {
          // for loop
          
          for (int i = 0; i < charArr.Length; i++)
            {
              // check if the first and last character are the same
              if (charArr[i] != charArr[charArr.Length - 1 - i])
                {
                  return false;
              }
          }

          return true;
        }
    }
}
