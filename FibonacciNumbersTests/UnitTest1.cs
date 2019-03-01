using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciNumbersTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CountLessOneThrowArgumentException()
        {
            //Arrange
            int count = 0;
            List<int> expected;

            //Act, Assert
            expected=FibonacciNumbers.Program.FibonacciNumbers(count);
        }

        [TestMethod]
        public void CountEqualOneResultIsOne()
        {
            //Arrange
            int count = 1;
            List<int> expected=new List<int> { 1 };

            //Act
            List<int> actual = FibonacciNumbers.Program.FibonacciNumbers(count);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountEqualTwoResultIsOne()
        {
            //Arrange
            int count = 2;
            List<int> expected;

            //Act
            expected = FibonacciNumbers.Program.FibonacciNumbers(count);
            List<int> actual = new List<int> { 1, 1 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
                
        [TestMethod]        
        public void CountMoreThanThreeAndResultLessOrEqualIntMaxValue()
        {
            //Arrange
            int count = 20;
            List<int> expected;

            //Act
            expected = FibonacciNumbers.Program.FibonacciNumbers(count);
            List<int> actual = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void ResultMoreThanIntMaxValueThrowOverflowException()
        {
            //Arrange
            int count = 50;
            List<int> expected;

            //Act, Assert
            expected = FibonacciNumbers.Program.FibonacciNumbers(count);
        }
    }
}
