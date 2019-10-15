// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryPatternComputer
{
    /// <summary>
    /// Computer Factory
    /// </summary>
    public class ComputerFactory 
    {
        /// <summary>
        /// GetType
        /// </summary>
        /// <param name="type"></param>
        /// <returns interFaceObject></returns>
        public static ComputerInterFace GetType(string type)
        {
            ComputerInterFace interFaceObject = null;
            if (type.ToLower() == "computer")
            {
                interFaceObject = new Computer(); 
            }
            else if (type.ToLower() == "laptop")
            {
                interFaceObject = new Laptop();
            }
            else if (type.ToLower() == "serverpc")
            {
                interFaceObject = new ServerPc();
            }

            return interFaceObject;
        }
    }
}
