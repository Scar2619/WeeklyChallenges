using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            var sum = 0;

            foreach (var i in numbers)
            {
                sum += i;
            }
                if (sum % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string regex = "^(?=.*[a-z])(?=."
                   + "*[A-Z])(?=.*\\d)";
            Regex p = new Regex(regex);

            if (password == null)
            {
                return false;
            }
            Match m = p.Match(password);

            if (m.Success)
            {
                return true;
            }
            else return false;
        }
        /*var isLower = false;
         var isUpper = false;
        var isNumber = false;

        for (var i = 0; i < password.Length; i++)
        {
            if(char.IsLower(password[i]))
            {
                isLower = true;
            }
            if (char.IsUpper(password[i]))
            {
                isUpper = true;
            }
            if(char.IsNumber(password[i]))
            {
                isNumber = true;
            }

        if(isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
                return false;
        }
        */

        

            public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
            //same as return val[val.Length - 1];
            // return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
            //return nums.Last() - nums.First();
            //return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //int[] odds = {
            //    1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
            //    27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
            //    51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
            //    75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            //};
            //return odds;

            var list = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
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
