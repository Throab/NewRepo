using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class InfoClient
    {
        public string clientIp { get; set; }
        public string stateClient { get; set; }
        public DateTime startTime { get; set; }
        public string remainMoney { get; set; }
        public Socket client { get; set; }
        public string memberName { get; set; }
    }
}
