using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeFactors.Tests
{
    /// <summary>
    /// Just a couple sanity checks that the PrimeFactorCalculator does the same as the FactorizationCalculator 
    /// that it wraps.
    /// </summary>
    [TestFixture]
    public class PrimeFactorCalculatorTests
    {
        [Test]
        public void Test_For_One()
        {
            var calculator = new PrimeFactorCalculator();

            CollectionAssert.AreEqual(calculator.Execute(1).ToList(), new List<int>() { });
        }

        [Test]
        public void Test_For_Two()
        {
            var calculator = new PrimeFactorCalculator();

            CollectionAssert.AreEqual(calculator.Execute(2).ToList(), new List<int>() { 2 });
        }

        [Test]
        public void Test_For_Eight()
        {
            var calculator = new PrimeFactorCalculator();

            CollectionAssert.AreEqual(calculator.Execute(8).ToList(), new List<int>() { 2, 2, 2 });
        }
    }
}
