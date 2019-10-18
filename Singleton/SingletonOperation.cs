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
                       () => MethodOfSamir(),
                       () => MethodOfSathish()
                      );

                        static void MethodOfSathish()
                        {
                            SingletonThredSafety b = SingletonThredSafety.GetInstance;
                            b.SingletonMethod("Satish");
                        }

                        static void MethodOfSamir()
                        {
                            SingletonThredSafety a = SingletonThredSafety.GetInstance;
                            a.SingletonMethod("samir");
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
