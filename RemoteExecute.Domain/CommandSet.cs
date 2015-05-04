using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Domain
{
    public class CommandSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Command> Commands { get; set; }
    }
}
