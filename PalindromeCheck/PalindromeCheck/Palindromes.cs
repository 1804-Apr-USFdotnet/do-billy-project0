using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    static public class Palindromes
    {
        public static bool IsPalindrome(string str)
        {
            string reversed;
            try
            {
                reversed = new string(str.ToLower().ToCharArray().Reverse().ToArray());
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str == reversed;
        }
    }
}
