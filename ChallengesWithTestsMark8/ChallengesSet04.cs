using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }

                if(num %2 ==1)
                {
                    sum += num * -1;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            if(str1.Length <= str2.Length 
                && str1.Length <= str3.Length
                && str1.Length <= str4.Length)
            {
                return str1.Length;
            }

            if(str2.Length <= str1.Length
                && str2.Length <= str3.Length
                && str2.Length <= str4.Length)
            {
                return str2.Length;
            }

            if(str3.Length <= str1.Length
                && str3.Length <= str2.Length
                && str3.Length <= str4.Length)
            {
                return str3.Length;
            }

            if(str4.Length <= str1.Length
                && str4.Length <= str2.Length
                && str4.Length <= str3.Length)
            {
                return str4.Length;
            }

            return 0;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if(number1 <= number2 && number1 <= number3 && number1 <= number4)
            {
                return number1;
            }

            if (number2 <= number1 && number2 <= number3 && number2 <= number4)
            {
                return number2;
            }

            if (number3 <= number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }

            if (number4 <= number1 && number4 <= number2 && number4 <= number3)
            {
                return number4;
            }

            return 0;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 <= sideLength3
                || sideLength3 + sideLength1 <= sideLength2
                || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }

            return true;
        }

        public bool IsStringANumber(string input) // .tryParse??
        {
            
            return Double.TryParse(input, out var output);
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int nonNullCount = 0;
            for(int i = 0; i < objs.Length; i++)
            {
                if(objs[i] == null)
                {
                    nullCount++;
                }

                else
                {
                    nonNullCount++;
                }
            }

            if(nullCount > nonNullCount)
            {
                return true;
            }

            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            double j = 0;
            double average = 0;
            List<int> listEvens = new List<int>();

            for(int i = 0; i < numbers.Length; i++ )
            {
                if(numbers[i] % 2 == 0)
                {
                    j++;
                    listEvens.Add(numbers[i]);
                }
            }

            if(listEvens.Count() == 0)
            {
                return 0;
            }

            int[] arrEven = listEvens.ToArray();
            average = arrEven.Sum() / j;
            return average;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int answer = 1;
            for (int i = 1; i <= number; i++)
            {
                answer = answer * i;
            }
            return answer;
        }
    }
}
