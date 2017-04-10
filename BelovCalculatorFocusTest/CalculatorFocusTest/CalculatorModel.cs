using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFocusTest
{
    public class CalculatorModel
    {
        public enum Operation
        {
            Plus, Equals, SquareRoot
        }
        /*
         * const -> readonly
         * static const -> const
         * static -> static
         */
        
        public double VisibleRegister {
            get; private set;
        }

        private double inVisibleRegister;
        private Operation operation;
        private bool isEnteringNumber;

        public CalculatorModel()
        {
            VisibleRegister = 0;
            inVisibleRegister = 0;
            operation = Operation.Plus;
            isEnteringNumber = false;
        }

        public void DigitPressed(int digit)
        {
            if (!isEnteringNumber)
            {
                inVisibleRegister = VisibleRegister;
                VisibleRegister = digit;
                isEnteringNumber = true;
            }
            else
            {
                VisibleRegister = VisibleRegister * 10 + digit;
            }
        }

        public void BinaryOperation(Operation newOperation)
        {
            switch (operation)
            {
                case Operation.Plus:
                    VisibleRegister += inVisibleRegister;

                    break;
                case Operation.Equals:
                    // store previous operation
                    newOperation = operation;
                    break;
                
            }
            operation = newOperation;
            isEnteringNumber = false;

        }
    }
}
