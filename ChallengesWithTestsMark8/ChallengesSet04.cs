using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {//DONE
            int sum = 0;

            foreach (var i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else sum -= i;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {//DONE
            string[] input = { str1, str2, str3, str4 };

            return input.Min(w => w.Length);
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {//DONE
            int[] input = { number1, number2, number3, number4 };

            return input.Min();
        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {//DONE
            //throw new NotImplementedException();
            //biz.Name.Replace(biz.Name, "TrueCoders");
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {//DONE

            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 ||
                            sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {//DONE
            if (input == null)
            {
                return false;
            }
            double i = 0;
            string s = input;
            return double.TryParse(s, out i);
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {//DONE
            int nullResult = objs.Count(s => s == null);
            int objsResult = objs.Count();

            if (nullResult > objsResult / 2)
            {
                return true;
            }
            return false;
        }


        public double AverageEvens(int[] numbers)
        {//DONE

            if (numbers == null)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0).Sum();
            var evensLength = numbers.Where(x => x % 2 == 0).Count();
     
            
            if (!numbers.Any(x => x % 2 == 0))
            {
                return 0;
            }
            return Convert.ToDouble(evens) / Convert.ToDouble(evensLength);


        }

        public int Factorial(int number)
        {//DONE

            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
                return number * Factorial(number - 1);

        }
    }
}
