using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Core.Interfaces
{
    public interface IOperationFactory
    {
        IEnumerable<IOperationData> AvailableOperations { get; }
        IOperation GetOperation(string symbol);
    }
}
