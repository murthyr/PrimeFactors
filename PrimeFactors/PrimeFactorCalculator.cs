using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    /// <summary>
    /// Simple wrapper for the <see cref="FactorizationCalculator"/> so we 
    /// conform to the <see cref="IPrimeFactorCalculator"/> interface.
    /// </summary>
    public class PrimeFactorCalculator : IPrimeFactorCalculator
    {
        /// <summary>
        /// Take a number and get the list of prime factors. 
        /// </summary>
        public IList<int> Execute(int number)
        {
            return FactorizationCalculator.Calculate(number);
        }
    }
}
