using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactors.VSTests
{
    /// <summary>
    /// Series of tests to build up an algorithm for calculating prime factors.  Basically using the numbers 1 - 9 and then adding a 
    /// couple extra scenarios on top for good measure.
    /// </summary>
    [TestClass]
    public class FactorizationCalculatorTests
    {
        [TestMethod]
        public void Test_For_One()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(1).ToList(), new List<int>() { });
        }

        [TestMethod]
        public void Test_For_Two()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(2), new List<int>() { 2 });
        }

        [TestMethod]
        public void Test_For_Three()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(3), new List<int>() { 3 });
        }

        [TestMethod]
        public void Test_For_Four()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(4), new List<int>() { 2, 2 });
        }

        [TestMethod]
        public void Test_For_Five()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(5), new List<int>() { 5 });
        }

        [TestMethod]
        public void Test_For_Six()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(6), new List<int>() { 3, 2 });
        }

        [TestMethod]
        public void Test_For_Seven()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(7), new List<int>() { 7 });
        }

        [TestMethod]
        public void Test_For_Eight()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(8), new List<int>() { 2, 2, 2 });
        }

        [TestMethod]
        public void Test_For_Nine()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(9), new List<int>() { 3, 3 });
        }

        [TestMethod]
        public void Test_For_NintySix()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(96), new List<int>() { 2, 2, 2, 2, 2, 3 });
        }

        [TestMethod]
        public void Test_For_OneHundredTwenty()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(120), new List<int>() { 2, 2, 2, 3, 5 });
        }

        [TestMethod]
        public void Test_For_OneThousandEightHundredTwentyThree()
        {
            CollectionAssert.AreEqual(FactorizationCalculator.Calculate(1820), new List<int>() { 2, 2, 5, 7, 13 });
        }
    }
}
