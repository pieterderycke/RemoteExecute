using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Models
{
    public class CommandEditViewModel
    {
        public bool IsNewCommand { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Commands { get; set; }
        public string CommandTypes { get; set; }
    }
}
