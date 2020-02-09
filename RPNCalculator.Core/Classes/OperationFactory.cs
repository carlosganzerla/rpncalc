using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace RPNCalculator.Core.Classes
{
    public class OperationFactory : IOperationFactory
    {
        [ImportMany]
        private IEnumerable<Lazy<IOperation, IOperationData>> operations;
        private readonly CompositionContainer container;

        public OperationFactory()
        {
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory);
            container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        public IOperation GetOperation(string symbol)
        {
            foreach (var operation in operations)
            {
                if(symbol == operation.Metadata.Symbol)
                {
                    return operation.Value;
                }
            }
            return null;
        }
    }
}
