using DesignPattern;
using DesignPattern.FactoryPatternComputer;
using DesignPattern.NewFolder;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the Computer type");
            // string type = Console.ReadLine();

            // ComputerInterFace i1 = ComputerFactory.getType(type);
            // Console.WriteLine(i1.produce());
            Singleton a = Singleton.myMethod();
            a.SingletonMethod("samir");
            Singleton b = Singleton.myMethod();
            b.SingletonMethod("Satish");
          
        }
    }
}
