using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        static bool IsDivisible(int number, int divisor)
        {
            return number % divisor == 0;
        }
        static bool Is3NextTo5(int number)
        {
            string numberAsString = number.ToString();

            return numberAsString.Contains("35") || numberAsString.Contains("53");
        }

        public static List<string> MillNumbers(List<int> numbers)
        {
            if (numbers == null) {
                return new List<string>();
            }

            List<string> result = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (IsDivisible(numbers[i], 7)) {
                    result.Add("Buzzinga");
                }
                else if (IsDivisible(numbers[i], 15) || Is3NextTo5(numbers[i])) {
                    result.Add("FizzBuzz");
                }
                else if (IsDivisible(numbers[i], 5) || numbers[i].ToString().Contains("5")) {
                    result.Add("Buzz");
                }
                else if (IsDivisible(numbers[i], 3)) {
                    result.Add("Fizz");
                }
                else {
                    result.Add(numbers[i].ToString());
                }
            }

            return result;
        }
    }
}