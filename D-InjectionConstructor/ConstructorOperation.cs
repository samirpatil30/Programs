// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.D_InjectionConstructor
{
    /// <summary>
    /// Constructor Operation
    /// </summary>
    public class ConstructorOperation
    {
        /// <summary>
        /// Injections this instance.
        /// </summary>
        public void Injection()
        {
            //// Create the instance of service one
            ServiceOne service = new ServiceOne();
            Client client = new Client(service);
            client.serveMethod();
            //// Create the instance of service two
            ServiceTwo serviceTwo = new ServiceTwo();
            client = new Client(serviceTwo);
            client.serveMethod();
        }
    }
}
