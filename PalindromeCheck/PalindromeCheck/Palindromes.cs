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
            string simplified;
            string reversed;
            bool result;
            try
            {
                char[] strArr = str.ToLower().ToCharArray();
                strArr = Array.FindAll(strArr, ((c) => Char.IsLetterOrDigit(c)));
                simplified = new string(strArr.ToArray());
                reversed = new string(strArr.Reverse().ToArray());

                result = simplified == reversed;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
