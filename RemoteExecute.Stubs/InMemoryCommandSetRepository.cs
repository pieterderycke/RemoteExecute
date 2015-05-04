using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Stubs
{
    public class InMemoryCommandSetRepository : ICommandSetRepository
    {
        private readonly List<CommandSet> commands;

        public InMemoryCommandSetRepository()
        {
            commands = new List<CommandSet>();
        }

        public IEnumerable<CommandSet> GetCommandSets()
        {
            return commands;
        }

        public CommandSet GetCommandSet(int id)
        {
            return commands[id];
        }

        public void AddCommandSet(CommandSet command)
        {
            command.Id = commands.Count;
            commands.Add(command);
        }
    }
}
