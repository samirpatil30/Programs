// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerInterFace.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    /// <summary>
    /// Computer InterFace
    /// </summary>
    public interface ComputerInterFace
    {
        /// <summary>
        ///produce
        /// </summary>
        /// <returns></returns>
        string Produce();
    }

    /// <summary>
    /// Laptop
    /// </summary>
    public class Laptop : ComputerInterFace
    {
        //// implement the method of interface
        /// <summary>
        /// Produce
        /// </summary>
        /// <returns></returns>
        string ComputerInterFace.Produce()
        {
            return "Factory produceses laptop";
        }
    }

    /// <summary>
    /// Computer
    /// </summary>
    public class Computer : ComputerInterFace
    {
        //// implement the method of interface
        /// <summary>
        /// Produce
        /// </summary>
        /// <returns></returns>
        string ComputerInterFace.Produce()
        {
            return "Factory Produceses Computers";
        }   
    }

    /// <summary>
    /// Server Pc
    /// </summary>
    public class ServerPc : ComputerInterFace
    {
        //// implement the method of interface
        /// <summary>
        /// Produce
        /// </summary>
        /// <returns></returns>
        string ComputerInterFace.Produce()
        {
            return "Factory produces Server Pc";
        }
    }
}