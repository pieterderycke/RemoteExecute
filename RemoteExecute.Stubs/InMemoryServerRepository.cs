using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Stubs
{
    public class InMemoryServerRepository : IServerRepository
    {
        private List<Server> servers;

        public InMemoryServerRepository()
        {
            servers = new List<Server>();
            servers.Add(new Server(
                0,
                "Synology NAS",
                "192.168.1.2",
                new AuthenticationOption[] {
                    new AuthenticationOption() { 
                        ConnectionType = ConnectionType.Ssh, 
                        UserName = "admin", 
                        Password = "test"
                    },
                }
            ));
            servers.Add(new Server(
                1,
                "Mac Server",
                "192.168.1.3",
                new AuthenticationOption[] {
                    new AuthenticationOption() { 
                        ConnectionType = ConnectionType.Ssh, 
                        UserName = "root", 
                        Password = "root"
                    },
                }
            ));
            servers.Add(new Server(
                2,
                "A Windows Server",
                "192.168.1.4",
                new AuthenticationOption[] {
                    new AuthenticationOption() { 
                        ConnectionType = ConnectionType.PowerShell, 
                        UserName = "Administrator", 
                        Password = "root"
                    },
                }
            ));
        }

        public IEnumerable<Server> GetServers()
        {
            return servers;
        }
    }
}
