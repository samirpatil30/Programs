using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    public class ProxyPattern
    {
        public void Proxy()
        {
            ProxyServer proxy = new ProxyServer();
            Console.WriteLine("Data from proxy = {0}", proxy.GetData());
        }
    }
}
