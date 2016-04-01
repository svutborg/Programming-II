using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net;

namespace SimpleHost
{
    class Program
    {
        static bool Shutdown = false;
        static IPAddress HostIP = IPAddress.None;
        static int HostPort = 7913;

        static void Main(string[] args)
        {
            IPAddress[] IPs = Dns.GetHostAddresses(Dns.GetHostName());
            List<IPAddress> ValidIPs = new List<IPAddress>();

            foreach (IPAddress ip in IPs)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ValidIPs.Add(ip);
                }
            }
            Console.WriteLine("Welcome to simple host");
            if(ValidIPs.Count > 1)
            {
                Console.WriteLine("Choose hosting IP address:");
                for(int i = 0; i < ValidIPs.Count; i++)
                {
                    Console.WriteLine(string.Format("{0,2}: {1}",i,ValidIPs[i]));
                }
                HostIP = ValidIPs[int.Parse(Console.ReadLine())];
            }
            else if(ValidIPs.Count > 0)
            {
                HostIP = ValidIPs[0]; // Assigning host to only available IP
            }
            else
            {
                Console.WriteLine("No valid network interfaces available. Quitting...");
                return;  // Exiting application
            }

            Console.WriteLine(string.Format("Hosting server @ {0}:{1}", HostIP, HostPort));
            Console.WriteLine("Press 'q' to exit application");
            IPEndPoint Endpoint = new IPEndPoint(HostIP, HostPort);
            TcpListener Listener = new TcpListener(Endpoint);
            
            Thread LT = new Thread(ListenerThread);
            LT.Name = "Listener Thread";
            LT.IsBackground = true;
            LT.Start(Listener);
            
            while (Console.ReadKey().Key != ConsoleKey.Q); // Ending application when q is pressed
            Shutdown = true;
            while (LT.IsAlive) ;
        }

        private static void ListenerThread(object arg)
        {
            TcpListener Listener = (TcpListener)arg;
            List<Thread> ClientThreads = new List<Thread>();
            int ThreadCount = 0;

            Listener.Start();
            while(!Shutdown)
            {
                if(Listener.Pending())
                {
                    Socket ClientSocket = Listener.AcceptSocket();
                    Thread CT = new Thread(ClientThread);
                    try {
                        CT.Name = Dns.GetHostEntry((ClientSocket.RemoteEndPoint as IPEndPoint).Address).HostName;
                    }
                    catch(Exception)
                    {
                        CT.Name = string.Format("Client #{0}", ThreadCount++);
                    }
                    CT.IsBackground = true;
                    CT.Start(ClientSocket);
                    Console.WriteLine(string.Format("{0} Connected", CT.Name));
                    ClientThreads.Add(CT);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
            Listener.Stop();
        }

        private static void ClientThread(object arg)
        {
            Socket ClientSocket = (Socket)arg;
            
            while(!(ClientSocket.Poll(1, SelectMode.SelectRead) && ClientSocket.Available == 0))
            {
                if (ClientSocket.Available>0)
                {
                    byte[] ReceiveBuffer = new byte[100];
                    ClientSocket.Receive(ReceiveBuffer);
                    Console.WriteLine(string.Format("{0} --> {1}", Thread.CurrentThread.Name, Encoding.ASCII.GetString(ReceiveBuffer)));
                    ClientSocket.Send(ReceiveBuffer);
                }
                Thread.Sleep(100);
            }   
            Console.WriteLine(string.Format("{0} disconnected", Thread.CurrentThread.Name));
        }
    }
}
