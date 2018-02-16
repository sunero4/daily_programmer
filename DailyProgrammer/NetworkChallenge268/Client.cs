using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.NetworkChallenge268
{
    internal class Client
    {
        public void StartClient()
        {
            var receivedBuffer = new byte[1024];

            var sender = new Socket(IPHelper.GetLocalIpAddress().AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            var endPoint = new IPEndPoint(IPHelper.GetLocalIpAddress(), 8080);

            try
            {
                sender.Connect(endPoint);

                Console.WriteLine("Connected to server at remote endpoint: {0}", sender.RemoteEndPoint.ToString());

                var message = Console.ReadLine();
                var messageBytes = Encoding.ASCII.GetBytes(message);

                sender.Send(messageBytes);

                var bytesReceived = sender.Receive(receivedBuffer);
                var receivedMessage = Encoding.ASCII.GetString(receivedBuffer, 0, bytesReceived);
                Console.WriteLine("Received echo: {0}", receivedMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
