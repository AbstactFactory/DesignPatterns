using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.infrastructure
{
    public class GetSumPriceCommand : ICommand
    {
        public IOrder Order { get; set; }

        public ICommandExecutionResult Execute()
        {
            return new GetSumPriceCommandExecutionResult
                       {
                           Sum = Order.GetSumPrice(),
                           Success = true
                       };
        }

        public ICommandUndoResult Undo()
        {
            return new GetSumPriceCommandUndoResult
                       {
                           Success = true
                       };
        }
    }

    public class GetSumPriceCommandExecutionResult : ICommandExecutionResult
    {
        public bool Success { get; set; }

        public int Sum { get; set; }

        public override string ToString()
        {
            return "Total:  " + Sum;
        }
    }

    public class GetSumPriceCommandUndoResult: ICommandUndoResult
    {
        public bool Success { get; set; }
    }
}
