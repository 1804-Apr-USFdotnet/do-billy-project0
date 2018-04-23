using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    static public class Palindromes
    {
        static bool IsPalindrome(string str)
        {
            string reversed;
            try
            {
                reversed = str.Reverse().ToString();
            }
            catch (NullReferenceException ex)
            {
                return false;
            }
            return str == reversed;
        }
    }
}
