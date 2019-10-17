using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.D_InjectionConstructor
{
    interface InjectionInterface
    {
        public void GetDetails();
    }

    public class ServiceOne : InjectionInterface
    {
        public void GetDetails()
        {
            Console.WriteLine("Service1 Class Method");
        }
    }

    public class ServiceTwo : InjectionInterface
    {
        public void GetDetails()
        {
            Console.WriteLine("Serviced 2 class Method");
        }
    }
    class Client
    {
        InjectionInterface injection;
        public Client(InjectionInterface injectionInterface)
        {
            injection = injectionInterface;
        }

        public void serveMethod()
        {
            Console.WriteLine("Method belongs to client class");
            injection.GetDetails();
        }
    }
}
