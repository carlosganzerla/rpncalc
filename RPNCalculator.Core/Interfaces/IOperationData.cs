using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Core.Interfaces
{
    public interface IOperationData
    {
        string Symbol { get; }

        string Description { get; }
    }
}
