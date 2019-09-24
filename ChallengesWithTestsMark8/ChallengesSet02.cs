using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if(num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double min = numbers.Min();
            double max = numbers.Max();
            double answer = min + max;
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int returnLength;
            if(str1.Length > str2.Length)
            {
                returnLength = Convert.ToInt32(str2.Length);
                return returnLength;
            }
            else
            {
                returnLength = Convert.ToInt32(str1.Length);
                return returnLength;
            }

        }

        public int Sum(int[] numbers)
        {
            int nullInt = 0;
            if(numbers == null)
            {
                return nullInt;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                 return 0;
            }
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 ==  0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 == 1 || numbers.Sum() % 2 == -1)
            {
                return true;
            }
            else //if(numbers.Sum() % 2 ==0)
            {
                return false;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            
            if(number <= 0)
            {
                return 0;
            }
           
            long count = 0; 
            for(long i = (number -1); i >= 0; i--) 
            {
                if(i % 2 == 1) //if odd
                {
                    count++;
                }
            }
            return count;
            
            
        }
    }
}
