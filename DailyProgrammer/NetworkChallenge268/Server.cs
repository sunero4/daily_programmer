using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer.NetworkChallenge268
{
    class Server
    {
        private Socket _listener;
        public bool Listening { get; set; }
        public void StartListening()
        {

            var ip = IPHelper.GetLocalIpAddress();
            _listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            var endPoint = new IPEndPoint(ip, 8080);
            Listening = true;
            try
            {
                _listener.Bind(endPoint);
                _listener.Listen(10);


                string stringData = "";
                while (Listening)
                {
                    Console.WriteLine("Listening for incoming connections...");

                    //Blocking call to listen for connections
                    var connectionHandler = _listener.Accept();

                    using (var networkStream = new NetworkStream(connectionHandler))
                    {
                        byte[] buffer = new byte[1024];
                        using (var memoryStream = new MemoryStream())
                        {
                            int bytes;
                            while ((bytes = networkStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                memoryStream.Write(buffer, 0, bytes);
                            }
                            stringData = Encoding.ASCII.GetString(memoryStream.ToArray(), 0, (int) memoryStream.Length);
                        }
                    }
                    Console.WriteLine("Received message: {0}", stringData);

                    var echoMessage = Encoding.ASCII.GetBytes(stringData);
                    connectionHandler.Send(echoMessage);
                    connectionHandler.Shutdown(SocketShutdown.Both);
                    connectionHandler.Close();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
