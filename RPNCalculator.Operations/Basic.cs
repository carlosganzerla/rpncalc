using RPNCalculator.Core.Interfaces;
using System;
using System.ComponentModel.Composition;

namespace RPNCalculator.Operations
{
    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "+")]
    [ExportMetadata(nameof(IOperationData.Description), "Adds two operands")]
    public class Add : IOperation
    {
        public int Operands => 2;

        public double Execute(double top, double second)
        {
            return top + second;
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "*")]
    [ExportMetadata(nameof(IOperationData.Description), "Multiplies two operands")]
    public class Multiply : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return top * second;
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "-")]
    [ExportMetadata(nameof(IOperationData.Description), "Subtracts two operands")]
    public class Subtract : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return second - top;
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "/")]
    [ExportMetadata(nameof(IOperationData.Description), "Divides two operands")]
    public class Divide : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return second / top;
        }
    }


    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "%")]
    [ExportMetadata(nameof(IOperationData.Description), "Modulo operation")]
    public class Mod : IOperation
    {
        public int Operands => 2;
        public double Execute(double top, double second)
        {
            return second % top;
        }
    }
}
