using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPracticeProblem
{
    public class NearestNumber
    {
        public void FindClosestNumberWithEvenDigits(int N)
        {
            if (N >= 0)
            {
                FindClosestNumberWithEvenDigitsPositive(N);
            }
            else
            {
                FindClosestNumberWithEvenDigitsNegative(N);
            }
        }

        public int FindClosestNumberWithEvenDigitsPositive(int N)
        {
            int current = N;
            while (true)
            {
                if (ContainsOnlyEvenDigits(current))
                {
                    return current;
                }
                current++;
            }
        }

        public int FindClosestNumberWithEvenDigitsNegative(int N)
        {
            int current = N;
            while (true)
            {
                if (ContainsOnlyEvenDigits(current))
                {
                    return current;
                }
                current--;
            }
        }

        public bool ContainsOnlyEvenDigits(int number)
        {
            string digits = Math.Abs(number).ToString();
            foreach (char digit in digits)
            {
                int digitValue = int.Parse(digit.ToString());
                if (digitValue % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
