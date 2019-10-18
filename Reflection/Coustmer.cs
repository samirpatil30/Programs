// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coustmer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Coustmer
    /// </summary>
    public class Coustmer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coustmer"/> class.
        /// </summary>
        public Coustmer()
        {
            Console.WriteLine("Constructor");
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        private string lastName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public int salary { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public string company { get; set; }

        Type type = typeof(Coustmer);

        /// <summary>
        /// Coustmers the details.
        /// </summary>
        public void CoustmerDetails()
        {
        }

        /// <summary>
        /// Get
        /// </summary>
        public void get()
        {
            Console.WriteLine("Class :: " + type.Name);
            Console.WriteLine("Name space :: " + type.Namespace);
            PropertyInfo[] propertyInfos = this.type.GetProperties();
            ConstructorInfo[] constructors = this.type.GetConstructors();
            MethodInfo[] methods = this.type.GetMethods();
            Console.WriteLine("The list of properties of the Customer class are:--");
            //// iterate the propertyInfos
            foreach (PropertyInfo pInfo in propertyInfos)
            {
                Console.WriteLine(pInfo.PropertyType.Name + " : " + pInfo.Name);
            }
            //// iterate the constructors
            foreach (ConstructorInfo cInfo in constructors)
            {
                Console.WriteLine("Constructor Name :: " + cInfo);
            }
            //// iterate the methods
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " :: " + method.Name);
            }
        }
    }
}
