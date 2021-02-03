using NUnit.Framework;
using System;

namespace CalculatorProgram.Test.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        // ** Start tests of Add() ** //
        [Test]
        public void Add_AddTwoPositiveNumbers_NumbersAreAddedCorrectly()
        {
            Assert.That(uut.Add(12.50, 34.00), Is.EqualTo(46.50));
        }

        [Test]
        public void Add_AddTwoNegativeNumbers_NumbersAreAddedCorrectly()
        {
            Assert.That(uut.Add(-10.50, 34.00), Is.EqualTo(23.50));
        }

        [Test]
        public void Add_AddOneNegativeAndOnePositiveNumber_NumbersAreAddedCorrectly()
        {
            Assert.That(uut.Add(Math.Round( -5.80), Math.Round(34.80)), Is.EqualTo(29));
        }
        // ** End tests of Add() ** //


        // ** Start tests of Subtract() ** //
        [Test]
        public void Subtract_SubtractTwoPositiveNumbers_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Subtract(7.88, 2.88), Is.EqualTo(5.00));
        }

        [Test]
        public void Subtract_SubtractTwoNegativeNumbers_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Subtract(-7.88, -2.12), Is.InRange(-5.77, -5.75));
        }

        [Test]
        public void Subtract_SubtractOnePositiveAndOneNegativeNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Subtract(-7.88, 2.12), Is.EqualTo(-10.0));
        }
        // End tests of Subtract() //

        // ** Start tests of Multiply() ** //
        [Test]
        public void Multiply_MultiplyTwoPositiveNumbers_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Mulitply(5.20, 13.60), Is.EqualTo(70.72));
        }

        [Test]
        public void Multiply_MultiplyTwoNegativeNumbers_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Mulitply(-13.40, -2.25), Is.InRange(30.14, 30.16));
        }

        [Test]
        public void Multiply_MultiplyOnePositiveAndOneNegativeNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Mulitply(-4.50, 2.88), Is.InRange(-12.96, -12.95));
        }
        // End tests of Subtract() //


        // ** Start tests of Power() ** //
        [Test]
        public void Power_RaisePositiveNumberToThePowerOfPositiveNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Power(5.20, 2.00), Is.InRange(27.03, 27.05));
        }

        [Test]
        public void Power_RaiseNegativeNumberToThePowerOfPositiveNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Power(-5.20, 2.00), Is.InRange(27.03, 27.05));
        }

        [Test]
        public void Power_RaisePositiveNumberToThePowerOfNegativeNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(uut.Power(9.00, -0.50), Is.InRange(0.33, 0.34));
        }

        [Test]
        public void Power_RaiseNegativeNumberToThePowerOfNegativeNumber_NumbersAreSubtractedCorrectly()
        {
            Assert.That(() => uut.Power(-9.00, -0.50), Throws.InvalidOperationException);
        }

        // End tests of Power() //

        [Test]
        public void TestOfGitRep()
        {

        }
    }
}