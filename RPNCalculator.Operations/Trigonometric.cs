using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace RPNCalculator.Operations
{
    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "sin")]
    public class Sine : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return Math.Sin(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "cos")]
    public class Cossine : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return Math.Cos(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "tan")]
    public class Tangent : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return Math.Tan(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "sin")]
    public class Secant : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return 1/Math.Cos(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "cos")]
    public class Cossecant : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return 1 / Math.Sin(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "tan")]
    public class Cotangent : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return 1 / Math.Tan(top);
        }
    }
}
