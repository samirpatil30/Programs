// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FacadeClient.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacedePattern
{
    /// <summary>
    /// FacadeClient
    /// </summary>
    public class FacadeClient
    {
        /// <summary>
        /// Client
        /// </summary>
        public void Client()
        {
            Agent agent = new AgentBooking();
            agent.Book();    
        }
    }
}
