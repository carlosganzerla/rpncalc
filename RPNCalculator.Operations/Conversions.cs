using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace RPNCalculator.Operations
{
    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "deg2rad")]
    public class DegToRadian : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return top * Math.PI / 180;
        }
    }

    [Export(typeof(IOperation))]
    [ExportMetadata(nameof(IOperationData.Symbol), "rad2deg")]
    public class RadianToDeg : IOperation
    {
        public int Operands => 1;
        public double Execute(double top, double second)
        {
            return top * 180 / Math.PI;
        }
    }
}
