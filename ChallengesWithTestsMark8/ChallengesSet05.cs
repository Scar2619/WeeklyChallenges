using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {//done
            return ((startNumber / n) + 1) * n;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {//DONE
            for (var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }

            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {//DONE
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;


        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {//done
            var sum = 0;
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if(numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {//done
            if (words == null || !words.Any())
            {
                return "";
            }

            string newString = "";

            foreach(var word in words)
            {
                if(word.Trim().Length > 0)
                {
                    newString += word.Trim() + " ";
                }
            }
            if (newString.Length == 0)
            {
                return "";
            }

            newString = newString.Substring(0, newString.Length - 1);
            newString += ".";
            return newString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {//DONE
            if (elements == null || !elements.Any())
            {
                return Array.Empty<double>();
            }
            var ans = new List<double>();

            for (var i = 3; i < elements.Count(); i += 4)
            {
                ans.Add(elements[i]);
            }
            return ans.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {//done
            for(var i = 0; i < nums.Length; i++)
            {
                for(var k = i + 1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
