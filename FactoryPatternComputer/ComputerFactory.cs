using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternComputer
{
   public class ComputerFactory 
    {
        public static ComputerInterFace getType(string type)
        {
            ComputerInterFace interFaceObject = null;
            if(type.ToLower() == "computer")
            {
                interFaceObject = new Computer(); 
            }
            else if(type.ToLower() == "laptop")
            {
                interFaceObject = new Laptop();
            }
            else if(type.ToLower() == "serverpc")
            {
                interFaceObject = new ServerPc();
            }

            return interFaceObject;
        }

    }
}
