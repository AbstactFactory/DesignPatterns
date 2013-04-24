using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace templates.infrastructure
{
    public class CommandQueueProcessor : ICommandProcessor
    {
        public IEnumerable<ICommand> Commands { get; set; }

        private int _runPosition = 0;

        public void AddCommandToExecute(ICommand command)
        {
            ((Queue<ICommand>) Commands).Enqueue(command);
        }

        public ICommandExecutionResult Run()
        {
            return Commands.ToArray()[_runPosition++].Execute();
        }

        public ICommandUndoResult Undo()
        {
            --_runPosition;
            return ((Queue<ICommand>) Commands).Dequeue().Undo();
        }
    }
}
