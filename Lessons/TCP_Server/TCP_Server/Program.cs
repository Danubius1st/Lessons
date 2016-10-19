using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace TCP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listen = new TcpListener(IPAddress.Any, 1200);
            Console.WriteLine("[Listening ...]");
            listen.Start();

            TcpClient client = listen.AcceptTcpClient();
            Console.WriteLine("[Client connected]");

            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int data = stream.Read(buffer, 0, client.ReceiveBufferSize);
            string ch = Encoding.Unicode.GetString(buffer, 0, data);
            Console.WriteLine("Message received: " + ch);
            client.Close();
            Console.ReadKey();
        }
    }
}
