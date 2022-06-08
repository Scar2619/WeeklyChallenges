using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();
            var answer = minuend -= subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            var answer = number1 += number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            //throw new NotImplementedException();
            var answer = factor1 *= factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();
            if (nameOfPerson == "")
            {
                return $"Hello!";
            }
            else return $"Hello, {nameOfPerson}!";

        }

        public string GetHey()
        {
            //throw new NotImplementedException();
            return "HEY!";

        }
    }
}
