using RPNCalculator.Core.Interfaces;
using System;
using System.ComponentModel.Composition;
namespace RPNCalculator.Operations
{

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "^")]
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
