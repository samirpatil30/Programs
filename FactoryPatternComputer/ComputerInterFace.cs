using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface ComputerInterFace
    {
        string produce();
    }

    public class Laptop : ComputerInterFace
    {
        string ComputerInterFace.produce()
        {
            return "Factory produceses laptop";
        }
    }
    public class Computer : ComputerInterFace
    {
        string ComputerInterFace.produce()
        {
            return "Factory Produceses Computers";
        }
    }

    public class ServerPc : ComputerInterFace
    {
        string ComputerInterFace.produce()
        {
            return "Factory produces Server Pc";
        }
    }


}

