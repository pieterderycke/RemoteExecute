using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Domain
{
    public interface IExecutionEngine
    {
        void Execute(CommandSet commandSet, ConnectionType connectionType);
    }
}
