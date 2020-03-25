using NUnit.Framework;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumbersTest()
        {
            List<int> numbers = new List<int>() {1, 2, 4, 202};
            List<string> expectedResults = new List<string>() {"1", "2", "4", "202"};
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void FizzTest()
        {
            List<int> numbers = new List<int>() {3, 6, 9, 12};
            List<string> expectedResults = new List<string>() {"Fizz", "Fizz", "Fizz", "Fizz"};
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BuzzTest()
        {
            List<int> numbers = new List<int>() {5, 10, 20, 51, 11577};
            List<string> expectedResults = new List<string>() {"Buzz", "Buzz", "Buzz", "Buzz", "Buzz"};
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void FizzBuzzTest()
        {
            List<int> numbers = new List<int>() {15, 30, 120, 351, 225377};
            List<string> expectedResults = new List<string>() {"FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz"};
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void BuzzingaTest()
        {
            List<int> numbers = new List<int>() {7, 105};
            List<string> expectedResults = new List<string>() {"Buzzinga", "Buzzinga"};
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }

        [Test]
        public void HandleNullTest()
        {
            List<int> numbers = null;
            List<string> expectedResults = new List<string>();
            var actualResults = FizzBuzzer.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}