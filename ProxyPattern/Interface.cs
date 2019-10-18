// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interface.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ----------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyPattern
{
    using System;

    /// <summary>
    /// Interface
    /// </summary>
    public interface Interface
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public string GetData();
    }

    /// <summary>
    /// Server
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyPattern.Interface" />
    public class Server : Interface
    {
        string data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        public Server()
        {
            Console.WriteLine("Server Initilize");
            data = "Hello i am server";
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            return data;
        }
    }

    /// <summary>
    /// Proxy Server
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyPattern.Interface" />
    public class ProxyServer : Interface
    {
        Server server = new Server();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyServer"/> class.
        /// </summary>
        public ProxyServer()
        {
            Console.WriteLine("This is Proxy-Server");
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            return server.GetData();
        }
    }
}
