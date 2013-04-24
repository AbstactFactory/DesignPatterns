using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.infrastructure
{
    public interface ICommandExecutionResult
    {
        bool Success { get; set; }
    }

    public interface ICommandUndoResult
    {
        bool Success { get; set; }
    }

    public interface ICommand
    {
        IOrder Order { get; set; }

        ICommandExecutionResult Execute();

        ICommandUndoResult Undo();
    }

    public interface ICommandProcessor
    {
        IEnumerable<ICommand> Commands { get; set; }

        void AddCommandToExecute(ICommand command);

        ICommandExecutionResult Run();

        ICommandUndoResult Undo();
    }
}
