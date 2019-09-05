using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator_Test_Unit
{     
[TestFixture]
    public class Class1
    {
        private Calc uut;
        [SetUp]

        public void Setup()
        {
           uut = new Calc();
        }

        [TestCase(2,2,4)]
        [TestCase(10,10,20)]
        [TestCase(27, 13, 40)]
        [TestCase(-10,-5,-15)]
        public void addCalculator_Test(double a, double b, double c)
        {
            //Arrange
            //Act
            uut.Add(a,b);
            //Assert
            Assert.That(uut.Add(a,b), Is.EqualTo(c));
        }


        [TestCase(4, 2, 2)]
        [TestCase(8, 3, 5)]
        [TestCase(10, 10, 0)]
        [TestCase(50, 60, -10)]
        public void SubCalculator_Test(double a, double b, double c)
        {
            //Arrange
            //Act
            uut.Sub(a, b);
            //Assert
            Assert.That(uut.Sub(a, b), Is.EqualTo(c));
        }

        [TestCase(4, 4, 16)]
        [TestCase(2,5, 10)]
        [TestCase(10, 10, 100)]
        [TestCase(-7, -3, 21)]
        public void MultiCalculator_Test(double a, double b, double c)
        {
            //Arrange
            //Act
            uut.Multi(a, b);
            //Assert
            Assert.That(uut.Multi(a, b), Is.EqualTo(c));
        }




        [TestCase(3,3,27)]
        [TestCase(-3, -3, -0.037037037037037035)]
        [TestCase(0, 0, 1)]
        [TestCase(-4, 2, 16)]
        public void PowerCalculator_Test(double a, double b, double c)
        {
            //Arrange
            //Act
            uut.Power(a, b);
            //Assert
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }


        [TestCase(9,3)]
        [TestCase(4,2)]
        [TestCase(16,4)]
        [TestCase(42, 6.4807406984078604)]
        public void SqrtCalculator_Test(double a, double b)
        {
            //Arrange
            //Act
            uut.Sqrt(a);
            //Assert
            Assert.That(uut.Sqrt(a), Is.EqualTo(b));
        }

    }
}
