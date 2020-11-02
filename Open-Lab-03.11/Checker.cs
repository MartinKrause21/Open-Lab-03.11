using NUnit.Framework;
using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            int i;
            bool isPalindrome = true;
            for ( i = 0; i < (str.Length / 2 + 1); i++)
            {
                if (!(str[i] == str[str.Length - i - 1]))
                {
                    return false;
                }

            }
            return isPalindrome;
        } 
    }
}
