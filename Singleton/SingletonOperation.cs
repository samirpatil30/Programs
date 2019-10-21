using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.NewFolder
{

   public class SingletonOperation
    {
        public void Singleton()
        {
            char character;
            do
            {
                Console.WriteLine("1) Singleton class using Thread safety \n 2)Singleton class using lazy initialization");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {                
                    case 1:
                        Parallel.Invoke(
                       () => MethodOfTwo(),
                       () => MethodOne()
                      );

                        static void MethodOne()
                        {
                            SingletonThredSafety b = SingletonThredSafety.GetInstance;
                            b.SingletonMethod("Method One");
                        }

                        static void MethodOfTwo()
                        {
                            SingletonThredSafety a = SingletonThredSafety.GetInstance;
                            a.SingletonMethod("Method two");
                        }
                        break;

                    case 2:

                        LazyInitialization lazy = LazyInitialization.GetInstanceOfLazyInitialization;
                        lazy.Lazy("samir");

                        LazyInitialization lazyOne = LazyInitialization.GetInstanceOfLazyInitialization;
                        lazyOne.Lazy("Satish");
                        break;

                }

                Console.WriteLine("Do you want to Continoue Y or N");
                character = Convert.ToChar(Console.ReadLine());
            } while (character == 'Y' || character == 'y');
        }
    }
}
