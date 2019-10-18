using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPattern.Reflection
{
   public class Coustmer
    {
        public Coustmer()
        {
            Console.WriteLine("Constructor");
        }
        private string lastName { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string company { get; set; }

        Type type = typeof(Coustmer);

        public void CoustmerDetails()
        {

        }
        public void get()
        {
            Console.WriteLine("Class :: " + type.Name);
            Console.WriteLine("Name space :: " + type.Namespace);
            PropertyInfo[] propertyInfos = type.GetProperties();
            ConstructorInfo[] constructors = type.GetConstructors();
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("The list of properties of the Customer class are:--");

            foreach (PropertyInfo pInfo in propertyInfos)
            {
                Console.WriteLine(pInfo.PropertyType.Name + " : " + pInfo.Name);
            }

            foreach (ConstructorInfo cInfo in constructors)
            {
                Console.WriteLine("Constructor Name :: " + cInfo);
            }

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+ " :: " + method.Name);
            }

        }
    }
}
