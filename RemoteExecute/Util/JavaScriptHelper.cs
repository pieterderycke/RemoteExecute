using Newtonsoft.Json;
using RemoteExecute.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteExecute.Util
{
    public static class JavaScriptHelper
    {
        public static string Serialize(IEnumerable<Server> servers)
        {
            Dictionary<string, List<object>> dictionary = new Dictionary<string, List<object>>();
            dictionary.Add("SSH", new List<object>());
            dictionary.Add("PowerShell", new List<object>());

            foreach(Server server in servers)
            {
                foreach (ConnectionType connectionType in server.AuthenticationOptions.Keys)
                {
                    switch (connectionType)
                    {
                        case ConnectionType.Ssh:
                            dictionary["SSH"].Add(new { name = server.Name, id = server.Id });
                            break;
                        case ConnectionType.PowerShell:
                            dictionary["PowerShell"].Add(new { name = server.Name, id = server.Id });
                            break;
                        default:
                            throw new Exception(string.Format("Unknown connection type \"{0}\".", connectionType));
                    }
                }
            }

            return JsonConvert.SerializeObject(dictionary);
        }
    }
}
