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
        [TestCase(4,4,8)]
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

        [Test]
        public void MultiCalculator_Test()
        {
            //Arrange
            //Act
            uut.Multi(3, 3);
            //Assert
            Assert.That(uut.Multi(3, 3), Is.EqualTo(9));
        }




        [TestCase(3,3,27)]
        [TestCase(-3, -3, -0.037037037037037035)]
        [TestCase(0, 0, 1)]
        public void PowerCalculator_Test(double a, double b, double c)
        {
            //Arrange
            //Act
            uut.Power(a, b);
            //Assert
            Assert.That(uut.Power(a, b), Is.EqualTo(c));
        }



        [Test]
        public void SqrtCalculator_Test()
        {
            //Arrange
            //Act
            uut.sqrt(9);
            //Assert
            Assert.That(uut.sqrt(9), Is.EqualTo(3));
        }

    }
}
