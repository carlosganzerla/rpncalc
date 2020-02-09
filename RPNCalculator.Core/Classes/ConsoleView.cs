using RPNCalculator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace RPNCalculator.Core.Classes
{
    public class ConsoleView
    {
        private readonly IOperationStack operationStack;

        public ConsoleView(IOperationStack operationStack)
        {
            this.operationStack = operationStack;
        }
        public void Refresh() 
        {
            Console.Clear();
            foreach (var value in operationStack.Values)
            {
                Console.WriteLine(value);
            }
        }

        public void DisplayErrorMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ReadValue()
        {
            var valueOrSymbol = Console.ReadLine();
            try
            {
                if (!operationStack.AddOperand(valueOrSymbol) && !operationStack.Operate(valueOrSymbol))
                {
                    DisplayErrorMessage($"Invalid symbol: {valueOrSymbol}");

                }
            }
            catch (Exception e)
            {
                DisplayErrorMessage(e.Message);
            }
            Refresh();
        }


        public void About()
        {
            Console.WriteLine(@"
                       _____          _____  _      ____  
                      / ____|   /\   |  __ \| |    / __ \ 
                     | |       /  \  | |__) | |   | |  | |
                     | |      / /\ \ |  _  /| |   | |  | |
                     | |____ / ____ \| | \ \| |___| |__| |
                      \_____/_/___ \_\_|_ \_\______\____/ 
                     |  __ \|  __ \| \ | |                
                     | |__) | |__) |  \| |                
                     |  _  /|  ___/| . ` |                
                     | | \ \| |    | |\  |                
                     |_|__\_\_|    |_|_\_|   _____        
                      / ____|   /\   | |    / ____|       
                     | |       /  \  | |   | |            
                     | |      / /\ \ | |   | |            
                     | |____ / ____ \| |___| |____        
                      \_____/_/    \_\______\_____|       
                    ");
            Console.WriteLine("RPN Calculator - By Carlo");
            Console.WriteLine("To perform a calculation, type the number and/or operation and press enter");
            Console.WriteLine("Expressions will be evaluated and automatically pushed/popped from the stack :)");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
