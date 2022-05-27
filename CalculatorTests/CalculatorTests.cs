using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10plus20_return30()
        {
            // arrange
            int x = 10;
            int y = 20;
            int expect = 30;
            // act
            int actual = MyCalc.Sum(x, y);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Substract_10minus5_return5()
        {
            // arrange 
            int x = 10;
            int y = 5; 
            int expect = 5;
            // act
            int actual = MyCalc.Substract(x, y);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Multiply_12multiplyNegative5_returnNegative60()
        {
            // arrange 
            int x = 12;
            int y = -5;
            int expect = -60;
            // act
            int actual = MyCalc.Multiply(x, y);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Divide_12divide4_return3()
        {
            // arrange 
            int x = 12;
            int y = 4;
            int expect = 3;
            // act
            int actual = MyCalc.Divide(x, y);
            // assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Divide_12divide0_throwsDivideByZeroException()
        {
            // arrange 
            int x = 12;
            int y = 0;
            // act & assert
            Assert.ThrowsException<DivideByZeroException>( ()=> { MyCalc.Divide(x, y); });
        }
    }
}
