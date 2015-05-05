using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.DataLayer
{
    public class SqlServerCommandRepository : ICommandSetRepository
    {
        public IEnumerable<CommandSet> GetCommandSets()
        {
            throw new NotImplementedException();
        }

        public CommandSet GetCommandSet(int id)
        {
            throw new NotImplementedException();
        }

        public void AddCommandSet(CommandSet commandSet)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommandSet(int id, string name, IEnumerable<Command> commands)
        {
            throw new NotImplementedException();
        }
    }
}
