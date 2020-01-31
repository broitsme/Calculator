using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calculator.Test
{
    [TestClass]
    public class Calculator_Test
    {

        [TestMethod]
        public void Add_Test()
        {
            Random random = new Random();
            for (double c = -100; c <= 100; c += 1)
            {
                //Arrange 
                double b = random.Next(0, 2);
                double a = c - b;
                //Act
                double actual = CalLib.Calculator.Add(a, b);
                //Assert
                Assert.AreEqual(actual, c);
            }
        }
        [TestMethod]
        public void Sub_Test()
        {

            Random random = new Random();
            for (double c = -100; c <= 100; c += 1)
            {
                double b = random.Next(0, 2);
                double a = c + b;
                double actual = CalLib.Calculator.Sub(a, b);
                Assert.AreEqual(actual, c);
            }

        }
        [TestMethod]
        public void Div_Test()
        {

            Random random = new Random();
            for (double c = -100; c <= 100; c += 1)
            {
                double b = random.Next(0, 2);
                double a = c * b;
                //if (b == 0)
                //{
                //    Assert.ThrowsException<System.DivideByZeroException>(() => CalLib.Program.Div(a, b));
                //}
                double actual = CalLib.Calculator.Div(a, b);
                Assert.AreEqual(actual, c);
            }

        }

        [TestMethod]
        public void Mul_Test()
        {
            Random random = new Random();
            for (double c = -100; c <= 100; c += 1)
            {
                double b = random.Next(1, 2);
                double a = c / b;
                double actual = CalLib.Calculator.Mul(a, b);
                Assert.AreEqual(actual, c);
            }
        }
    }
}