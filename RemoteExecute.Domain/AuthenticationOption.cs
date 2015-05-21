using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Domain
{
    public class AuthenticationOption
    {
        public ConnectionType ConnectionType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
