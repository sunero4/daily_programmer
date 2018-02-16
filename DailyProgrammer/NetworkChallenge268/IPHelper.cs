using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.NetworkChallenge268
{
    class IPHelper
    {

        /// <summary>
        /// Gets local IP. Uses answer from this SO thread: https://stackoverflow.com/questions/6803073/get-local-ip-address
        /// </summary>
        /// <returns>Local IP-Address</returns>
        public static IPAddress GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
    }
}
