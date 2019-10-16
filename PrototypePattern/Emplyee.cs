// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// ------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.PrototypePattern
{
    /// <summary>
    /// Employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 
        /// </summary>
        public int empId;

        /// <summary>
        /// 
        /// </summary>
        public EmployeeDescription description;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="companyName"></param>
        /// <param name="salary"></param>
        public Employee(int id, string name, string companyName, int salary)
        {
            empId = id;
            description = new EmployeeDescription(name, companyName, salary);
        }

        //// Clone the object
        /// <summary>
        /// Shallow Copy
        /// </summary>
        /// <returns></returns>
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Deep Copy
        /// </summary>
        /// <returns></returns>
        public Employee DeepCopy()
        {
            Employee emp = new Employee(this.empId, description.name, description.company, description.salary);
            return emp;
        }
    }

    /// <summary>
    /// EmployeeDescription
    /// </summary>
    public class EmployeeDescription
    {
        /// <summary>
        /// name
        /// </summary>
        public string name, company;
        /// <summary>
        /// salary
        /// </summary>
        public int salary;

        /// <summary>
        /// EmployeeDescription
        /// </summary>
        /// <param name="name"></param>
        /// <param name="companyName"></param>
        /// <param name="salary"></param>
        public EmployeeDescription(string name, string companyName, int salary)
        {
            this.name = name;
            this.company = companyName;
            this.salary = salary;
        }
    }
}
