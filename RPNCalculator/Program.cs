using RPNCalculator.Core.Classes;
using RPNCalculator.Core.Interfaces;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ConsoleView(new OperationStack(new OperationFactory()));
            view.About();
            while (true)
            {
                view.ReadValue();
            }
        }
    }
}
