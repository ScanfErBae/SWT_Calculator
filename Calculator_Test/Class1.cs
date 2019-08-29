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

        [Test]
        public void addCalculator_Test()
        {
            //Arrange
            //Act
            uut.Add(2,2);
            //Assert
            Assert.That(uut.Add(2,2), Is.EqualTo(4));
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


        [Test]
        public void SubCalculator_Test()
        {
            //Arrange
            //Act
            uut.Sub(5, 3);
            //Assert
            Assert.That(uut.Sub(5, 3), Is.EqualTo(2));
        }


        [Test]
        public void PowerCalculator_Test()
        {
            //Arrange
            //Act
            uut.Power(3, 3);
            //Assert
            Assert.That(uut.Power(3, 3), Is.EqualTo(27));
        }

    }
}
