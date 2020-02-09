using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Core.Interfaces
{
    public interface IOperationStack
    {
        public IEnumerable<double> Values { get; }
        bool AddOperand(string value);
        bool Operate(string symbol);
        void Clear();
    }
}
