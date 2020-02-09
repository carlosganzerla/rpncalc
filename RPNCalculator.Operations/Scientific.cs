using RPNCalculator.Core.Interfaces;
using System;
using System.ComponentModel.Composition;
namespace RPNCalculator.Operations
{

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "^")]
    [ExportMetadata(nameof(IOperationData.Description), "Exponential")]
    public class Exp : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return Math.Pow(second, top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "inv")]
    [ExportMetadata(nameof(IOperationData.Description), "Inverse of the number")]
    public class Invert : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return Math.Pow(top, -1);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "log")]
    [ExportMetadata(nameof(IOperationData.Description), "User defined base logarithm")]
    public class Log : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return Math.Log(second, top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "ln")]
    [ExportMetadata(nameof(IOperationData.Description), "Natural base logarithm")]
    public class Ln : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return Math.Log(top);
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "!")]
    [ExportMetadata(nameof(IOperationData.Description), "Factorial")]
    public class Factorial : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            if (top == 0) return 1;
            else return top * Execute(top - 1, second);
        }
    }

}
