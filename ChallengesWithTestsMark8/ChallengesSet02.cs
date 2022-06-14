using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
                return Char.IsLetter(c);
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var k = vals.Length;
            if (k % 2 == 0)
            {
                return true;
            }
            return false;

        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var one = str1.Count();
            var two = str2.Count();

            if(one > two)
            {
                return two;
            }
            return one;
        }

        public int Sum(int[] numbers)
        {
                if(numbers == null)
            {
                return 0;
            }

            return numbers.Sum();

        }

        public int SumEvens(int[] numbers)
        {
                if (numbers == null)
            {
                return 0;
            }

            if(numbers.Length == 0)
                {
                    return 0;
                }
            return numbers.Where(i => i % 2 == 0).Sum();   
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if(numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;                
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
