using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.D_InjectionConstructor
{
   public class ConstructorOperation
    {
        public void Injection()
        {
            ServiceOne service = new ServiceOne();
            Client client = new Client(service);
            client.serveMethod();

            ServiceTwo serviceTwo = new ServiceTwo();
            client = new Client(serviceTwo);
            client.serveMethod();

        }
    }
}
