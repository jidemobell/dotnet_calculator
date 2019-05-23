using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    /// <summary>
    /// Summary description for InputConverterTest
    /// </summary>
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter
            = new InputConverter();

        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.converInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.converInputToNumeric(inputNumber);

        }
    }
}
