using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    /// <summary>
    /// A calculator that finds the prime factors for any integer
    /// </summary>
    /// <remarks>
    /// Built this by going through the kata found here: http://craftsmanship.sv.cmu.edu/katas/prime-factors-kata
    /// </remarks>
    public static class FactorizationCalculator
    {
        public static List<int> Calculate(int number)
        {
            var primes = new List<int>();

            for (int candidate = 2; candidate <= number; candidate++)
            {
                while (number % candidate == 0)
                {
                    primes.Add(candidate);
                    number = number / candidate;
                }
            }

            return primes;
        }
    }
}
