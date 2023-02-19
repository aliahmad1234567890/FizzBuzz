using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzLibrary.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void GetFizzBuzzOutput_Range_ReturnsCorrectOutput()
        {
            // arrange
            var fizzbuzz = new FizzBuzz(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } },
    new Dictionary<int, int> { { 3, 3 }, { 5, 5 } });
            var start = 1;
            var end = 15;
            var expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n";

            // act
            var result = fizzbuzz.GetFizzBuzzOutput(start, end);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFizzBuzzOutput_Set_ReturnsCorrectOutput()
        {
            // arrange
            var fizzbuzz = new FizzBuzz(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } },
    new Dictionary<int, int> { { 3, 3 }, { 5, 5 } });
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected = "1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n";

            // act
            var result = fizzbuzz.GetFizzBuzzOutput(numbers);

            // assert
            Assert.AreEqual(expected, result);
        }

    }
}
