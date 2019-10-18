using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber % n == 0)
            {
                startNumber++;
            }

            while(startNumber % n != 0)
            {
                startNumber++;
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(Business biz in businesses)
            {
                if(biz.TotalRevenue == 0)
                {
                    biz.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            if(numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < numbers[i -1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

           int sum = 0;
           for(int i = 0; i < numbers.Length -1; i++)
           {
               if (numbers[i] % 2 == 0)
               {
                   sum += numbers[i + 1];
               }

           }
           return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null)
            {
                return "";
            }


            string sentence = "";
            for(int i = 0; i < words.Length; i++)
            {
                
                if(words[i].Trim() == "")
                {
                    sentence = sentence + "";
                    continue;
                }

                if (i == words.Length - 1)
                {
                    sentence = sentence + words[i].Trim() + ".";
                }
                else
                if (words[i] != " " || words[i] != "")
                {
                    sentence = sentence + words[i].Trim() + " ";
                }
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] emptyArray = new double[0];
            if(elements == null)
            {
                return emptyArray;
            }

            List<double> newList = new List<double> { };
            for(int i = 0; i < elements.Count; i++)
            {
                if(elements[i] % 4 == 0)
                {
                    newList.Add(elements[i]);
                }
            }
            double[] fourthsArray = newList.ToArray();
            return fourthsArray;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
