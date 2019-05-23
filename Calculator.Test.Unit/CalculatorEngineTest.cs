using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    { 
       private readonly CalculatorEngine calculatorEngine
        = new CalculatorEngine();
    
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultsForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;

            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultsForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;

            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }
    }
}
