using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.infrastructure
{
    public class AddProductCommand : ICommand
    {
        public IOrder Order { get; set; }

        public IProduct Product { get; set; }

        public ICommandExecutionResult Execute()
        {
            Order.AddProduct(Product);

            return new AddProductCommandExecutionResult
                       {
                           Success = true
                       };
        }

        public ICommandUndoResult Undo()
        {
            Order.RemoveProduct(Product);

            return new AddProductCommandUndoResult
                       {
                           Success = true
                       };
        }
    }

    public class AddProductCommandExecutionResult : ICommandExecutionResult
    {
        public bool Success { get; set; }
    }

    public class AddProductCommandUndoResult : ICommandUndoResult
    {
        public bool Success { get; set; }
    }
}
