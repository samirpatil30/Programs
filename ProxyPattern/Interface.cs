using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    public interface Interface
    {
        public string GetData();
    }

    public class Server : Interface
    {
        string data;
        public Server()
        {
            Console.WriteLine("Server Initilize");
            data = "Hello i am server";
        }

         public string GetData()
        {
            return data;
        }
    }


    public class ProxyServer : Interface
    {
        Server server = new Server();
        public ProxyServer()
        {
            Console.WriteLine("This is Proxy-Server");
        }

        public string GetData()
        {
            return server.GetData();
        }
    }
}
