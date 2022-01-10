using System;
using System.Collections.Generic;

namespace PalindromicNumberTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Determines if a number is a palindromic number, see https://en.wikipedia.org/wiki/Palindromic_number.
        /// </summary>
        /// <param name="number">Verified number.</param>
        /// <returns>true if the verified number is palindromic number; otherwise, false.</returns>
        /// <exception cref="ArgumentException"> Thrown when source number is less than zero. </exception>
        public static bool IsPalindromicNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be less than zero");
            }

            if (number == Reverse(number, 0))
            {
               return true;
            }

            return false;
        }

        public static int Reverse(int number, int reversedNumber)
        {
            if (number == 0)
            {
                return reversedNumber;
            }

            reversedNumber = (reversedNumber * 10) + (number % 10);
            return Reverse(number / 10, reversedNumber);
        }
    }
}
