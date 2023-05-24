using AlgorithmsDataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillSmart.Lessons.Lab3.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Init() 
        {
            calculator = new Calculator();
        }

        [TestMethod]
        [DataRow("1 2 + 3 * =", 9)]
        [DataRow("8 2 + 5 * 9 + =", 59)]
        public void CalculateExpressionTest(string expression, int expectedResult)
        {
            var actualResult = calculator.Calculate(expression);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}