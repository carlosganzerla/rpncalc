using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Hosting;
using System.Composition;
using System.Linq;
using System.Text;

namespace RPNCalculator.Core.Classes
{
    public class OperationStack : IOperationStack
    {
        public IEnumerable<double> Values => inner.Reverse();

        private readonly Stack<double> inner;

        private readonly IOperationFactory factory;
        public OperationStack(IOperationFactory factory)
        {
            this.inner = new Stack<double>();
            this.factory = factory;
        }

        public bool AddOperand(string value)
        {
            if (double.TryParse(value, out double operand))
            {
                inner.Push(operand);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AssertStack(int operands)
        {
            if(inner.Count < operands)
            {
                throw new InvalidOperationException("Stack does not have enough operands!");
            }
        }

        public bool Operate(string symbol)
        {
            var operation = factory.GetOperation(symbol);
            if (operation != null)
            {
                AssertStack(operation.Operands);
                double top = double.NaN;
                double second = double.NaN;
                if (operation.Operands > 0) top = inner.Pop();
                if (operation.Operands > 1) second = inner.Pop();
                inner.Push(operation.Execute(top, second));
                return true;
            }
            return false;
        }
    }
}
