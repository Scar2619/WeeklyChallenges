using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {//done
            //throw new NotImplementedException();
            bool correctWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lowercase = words.Select(x => x.ToLower()).ToList();
                correctWord = lowercase.Contains(word);
            }
            if (ignoreCase == false)
            {
                correctWord = words.Contains(word);
            }
            return correctWord;
        }


        public bool IsPrimeNumber(int num)
        {//done
            //throw new NotImplementedException();
            if (num == 0 || num == 1 || num < 0)
            {
                return false;
            }
            for (var i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public int IndexOfLastUniqueLetter(string str)
        {//done
            //throw new NotImplementedException();
            var index = -1;
            bool boolIndex;

            for (var i = 0; i < str.Length; i++)
            {
                boolIndex = true;

                for (var k = 0; k < str.Length; k++)
                {
                    if (str[i] == str[k] && i != k)
                    {
                        boolIndex = false;
                    }
                }
                if (boolIndex == true)
                {
                    index = i;
                }
            }
            return index;


        }


        public int MaxConsecutiveCount(int[] numbers)
        {//done
            var ans = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var currentSum = 1;

                for (var k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] != numbers[k])
                    {
                        break;
                    }
                    currentSum++;
                }
                if (currentSum > ans)
                {
                    ans = currentSum;
                }
            }
            return ans;

        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {//done
            List<double> ansList = new List<double>();
            double[] nullArray = new double[0];

            if (elements == null || !elements.Any())
            {
                return nullArray;
            }

            for (var i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    ansList.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    ansList.Clear();
                }
            }
            double[] ansArray = ansList.ToArray();
            return ansArray;

        }
    }
}
