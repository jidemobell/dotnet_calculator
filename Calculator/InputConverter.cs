using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputConverter
    {
        public double converInputToNumeric(string argTextInput)
        {
            double convertedNumber;
           // bool isConvertedSuccessful = double.TryParse(input, out convertedNumber);
            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("expected a numeric value");
            }
            return convertedNumber;
        }
    }
}
