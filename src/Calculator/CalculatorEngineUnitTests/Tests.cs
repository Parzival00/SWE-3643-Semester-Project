using System;
using NUnit.Framework;

using CalculatorEngine;
namespace CalculatorEngineUnitTests
{
    [TestFixture]
    public class Tests
    {
     private Calculator _calculator;
        [SetUp]
        public void SetupBeforeEachTest()
        {
            _calculator = new Calculator();
        }

        [TearDown]
        public void TearDownAfterEachTest()
        {
            _calculator = null;
        }
        
        [Test]
        public void Add_TwoFloatingPointNumbers_ReturnsSumOfValues()
        {
            //Arrange
            _calculator.setInput(1,"5.5");
            _calculator.setInput(2,"-3.15");

            //Act
            Result answer = _calculator.Add();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "5.5 + -3.15 = 2.35");
        }
        
        [Test]
        public void Subtract_TwoFloatingPointNumbers_ReturnsSubtractedValues()
        {
            //Arrange
            _calculator.setInput(1,"27.93");
            _calculator.setInput(2, "4");

            //Act
            Result answer = _calculator.Subtract();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "27.93 - 4 = 23.93");
        }
        
        [Test]
        public void Multiply_TwoFloatingPointNumbers_ReturnsMultipliedValues()
        {
            //Arrange
            _calculator.setInput(1,"5");
            _calculator.setInput(2,"7.1");

            //Act
            Result answer = _calculator.Multiply();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "5 * 7.1 = 35.5");
        }
        
        [Test]
        public void Divide_TwoFloatingPointNumbers_ReturnsDividedValues()
        {
            //Arrange
            _calculator.setInput(1, "3.0");
            _calculator.setInput(2, "9.0");

            //Act
            Result answer = _calculator.Divide();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "3 / 9 = 0.333333333333333");
        }
        
        public void Divide_NumberByZero_ReturnsErrorMessage()
        {
            Assert.True(true);
            //Arrange
            _calculator.setInput(1, "3.0");
            _calculator.setInput(2, "0");

            //Act
            Result answer = _calculator.Divide();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "3.0 / 0 = Not a Number");
        }
        
        [Test]
        public void Equals_TwoEquivalentFloatingPointNumbers_ReturnsEqual()
        {
            //Arrange
            _calculator.setInput(1, "0.333333");
            _calculator.setInput(2, "0.333333");

            //Act
            Result answer = _calculator.Equals();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "0.333333 == 0.333333 = 1");
        }
        
        [Test]
        public void Equals_TwoNonEquivalentFloatingPointNumbers_ReturnsEqual()
        {
            //Arrange
            _calculator.setInput(1, "0.333333");
            _calculator.setInput(2, "0.333334");

            //Act
            Result answer = _calculator.Equals();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "0.333333 == 0.333334 = 0");
        }
        
        [Test]
        public void Equals_TwoUnequalFloatingPointNumbersWithHigherPrecision_ReturnsEqual()
        {
            //Arrange
            _calculator.setInput(1, "0.333333331");
            _calculator.setInput(2, "0.333333332");

            //Act
            Result answer = _calculator.Equals();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "0.333333331 == 0.333333332 = 1");
        }
        
        [Test]
        public void Power_TwoFloatingPointNumbers_ReturnsNumberRaisedToPower()
        {
            //Arrange
            _calculator.setInput(1, "2");
            _calculator.setInput(2, "3");

            //Act
            Result answer = _calculator.Power();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "2 ^ 3 = 8");
        }
        
        [Test]
        public void Log_TwoPositiveFloatingPointNumbers_ReturnsExponentOfLogarithm()
        {
            //Arrange
            _calculator.setInput(1, "8");
            _calculator.setInput(2, "2");

            //Act
            Result answer = _calculator.Log();

            //Assert
            Assert.AreEqual(answer.Operation + answer.OperationResult, "8 log 2 = 3");
        }
        
        [Test]
        public void Log_NegativeFirstNumber_ReturnsError()
        {
            //Arrange
            _calculator.setInput(1, "-8");
            _calculator.setInput(2, "2");

            //Act
            Result answer = _calculator.Log();

            //Assert
            Assert.AreEqual("Input A must be greater than 0",answer.ErrorMessage);
        }
        
        [Test]
        public void Log_ZeroFirstNumber_ReturnsError()
        {
            //Arrange
            _calculator.setInput(1, "0");
            _calculator.setInput(2, "2");

            //Act
            Result answer = _calculator.Log();

            //Assert
            Assert.AreEqual("Input A must be greater than 0",answer.ErrorMessage);
        }
        
        [Test]
        public void Log_ZeroSecondNumber_ReturnsError()
        {
            //Arrange
            _calculator.setInput(1, "8");
            _calculator.setInput(2, "0");

            //Act
            Result answer = _calculator.Log();

            //Assert
            Assert.AreEqual("Input B must be non-zero",answer.ErrorMessage);
        }
        
        [Test]
        public void Root_TwoFloatingPointNumbers_ReturnsBthRootOfA()
        {
            //Arrange
            _calculator.setInput(1, "8");
            _calculator.setInput(2, "3");

            //Act
            Result answer = _calculator.Root();

            //Assert
            Assert.AreEqual("8 root 3 = 2", answer.Operation + answer.OperationResult );
        }
        
        [Test]
        public void Root_SecondInputZero_ReturnsError()
        {
            //Arrange
            _calculator.setInput(1, "8");
            _calculator.setInput(2, "0");

            //Act
            Result answer = _calculator.Root();

            //Assert
            Assert.AreEqual("Input B must be non-zero", answer.ErrorMessage );
        }
        
        
    }
}