using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS2_Control_Panel
{
    internal class Server
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Port { get; set; }

        public Server(string name, string adress, string port)
        {
            Name = name;
            Adress = adress;
            Port = port;
        }
    }
}
