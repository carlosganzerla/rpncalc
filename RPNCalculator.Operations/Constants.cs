using RPNCalculator.Core.Interfaces;
using System;
using System.ComponentModel.Composition;

namespace RPNCalculator.Operations
{
    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "pi")]
    public class Pi : IOperation
    {
        public int Operands => 0;
        public double Execute(double top, double second)
        {
            return Math.PI;
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "e")]
    public class E : IOperation
    {
        public int Operands => 0;
        public double Execute(double top, double second)
        {
            return Math.E;
        }
    }
}
