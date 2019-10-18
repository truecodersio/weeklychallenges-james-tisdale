using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 1)
                {
                    sum += num;
                }

                if( num < 0)
                {
                    sum += num * -1;
                }
            }

            if(sum % 2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if(password.Any(char.IsDigit) &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] characters = val.ToCharArray();
            return characters.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            decimal answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            int first = nums[0];
            int last = nums.Last();
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int[] array = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
            return array;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            
        }
    }
}
