using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Models
{
    public class CommandSetSummaryViewModel
    {
        public IEnumerable<CommandSet> Commands { get; set; }
    }
}
