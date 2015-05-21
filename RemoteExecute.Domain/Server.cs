using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Domain
{
    public class Server
    {
        public Server(int id, string name, string address, IEnumerable<AuthenticationOption> authenticationOptions)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.AuthenticationOptions = new Dictionary<ConnectionType, AuthenticationOption>();
            foreach(AuthenticationOption option in authenticationOptions)
            {
                if (this.AuthenticationOptions.ContainsKey(option.ConnectionType))
                    throw new ArgumentException(string.Format("Dupliciate AuthenticationOption \"{0}\".", option));
                else
                    this.AuthenticationOptions.Add(option.ConnectionType, option);
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public IDictionary<ConnectionType, AuthenticationOption> AuthenticationOptions { get; set; }
    }
}
