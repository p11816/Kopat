using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFocusTest
{
    interface ICalculatorController
    {
        void DigitPress(int digit);
        void BinaryOperation(CalculatorModel.Operation op);
    }
}
