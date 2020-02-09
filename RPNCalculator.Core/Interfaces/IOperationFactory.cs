using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Core.Interfaces
{
    public interface IOperationFactory
    {
        IOperation GetOperation(string symbol);
    }
}
