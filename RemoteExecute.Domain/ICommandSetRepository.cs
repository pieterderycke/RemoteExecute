using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Domain
{
    public interface ICommandSetRepository
    {
        IEnumerable<CommandSet> GetCommandSets();
        CommandSet GetCommandSet(int id);
        void AddCommandSet(CommandSet command);
    }
}
