using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace RPNCalculator.Core.Interfaces
{
    public interface IOperation
    {
        int Operands { get; }
        double Execute(double top, double second);
    }

}
