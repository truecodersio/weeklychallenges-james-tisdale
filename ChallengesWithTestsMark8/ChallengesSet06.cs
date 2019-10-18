using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            foreach (string str in words)
            {
                if(str == null)
                {
                    continue;
                }
                if(ignoreCase && word.ToLower() == str.ToLower())
                {
                    return true;
                }
                else if(!ignoreCase && word == str)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            if(num == 2 || num == 3 || num == 5)
            {
                return true;
            }
            if(num % 2 == 0)
            {
                return false;
            }
            if(num % 3 == 0)
            {
                return false;
            }
            if(num % 5 == 0)
            {
                return false;
            }
            if(num % 1 == 0 && num % num == 0)
            {
                return true;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int lastUniqueIndex = -1;
            for(int i = 0; i< str.Length; i++)
            {
                if(IsUnique(str, str[i]))
                {
                    lastUniqueIndex = i;
                }
            }
            return lastUniqueIndex;
        }

        public bool IsUnique(string s, char c)
        {
            int charCounter = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(c == s[i])
                {
                    charCounter++;
                }
            }
            if (charCounter > 1)
            {
                return false;
            }
            return true;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConCount = 0;
            int conCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    conCount++;
                }

                if(numbers[i] != numbers[i -1])
                {
                    conCount = 1;
                }

                if(conCount > maxConCount)
                {
                    maxConCount = conCount;
                }
            }
            return maxConCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> dubList = new List<double>();
            if(elements == null)
            {
                return dubList.ToArray();
            }

            if(n < 1)
            {
                return dubList.ToArray();
            }

            for(int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    dubList.Add(elements[i -1]);
                }
            }
            return dubList.ToArray();
        }
    }
}
