using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.NewFolder
{
   public  class Singleton
    {
        public static Singleton getInstanceOfObject = null; 
        int count = 0;
        private Singleton()
        {
           
        }

       public static Singleton myMethod()
        {
            if(getInstanceOfObject == null)
            {
                return new Singleton();
            }
         
            return getInstanceOfObject;
        }

        public void SingletonMethod(string message)
        {
            Console.WriteLine( message );
        }
    }
}
