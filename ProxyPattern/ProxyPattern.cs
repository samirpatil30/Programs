// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyPattern.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ----------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyPattern
{
    using System;

    /// <summary>
    /// Proxy Pattern
    /// </summary>
    public class ProxyPattern
    {
        /// <summary>
        /// Proxies this instance.
        /// </summary>
        public void Proxy()
        {
            ////create the instance of proxyserver
            ProxyServer proxy = new ProxyServer();
            Console.WriteLine("Data from proxy = {0}", proxy.GetData());
        }
    }
}
