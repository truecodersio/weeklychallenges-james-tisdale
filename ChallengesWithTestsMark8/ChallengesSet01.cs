﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            bool same = (num1 == num2);
            return same;  
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            int theAnswer = number1 + number2;
            return theAnswer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 == number2)
            {
                return number2;
            }
            else
            {
                if(number1 > number2)
                {
                    return number2;
                }
                else
                {
                    return number1;
                }
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long multAnswer = factor1 * factor2;
            return multAnswer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if(nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
