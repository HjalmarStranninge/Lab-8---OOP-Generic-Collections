using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8___OOP_Generic_Collections
{
    // Creating the class 'Employee'.
    internal class Employee
    {

        // The properties for Employee.

        public string ID { get; set; }
        public string Name { get; set; }  
        public string Gender { get; set; }
        public int Salary { get; set; }  


        // Constructor for the class

        public Employee(string id, string name, string gender, int salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Overrides the ToString() method to print the properties of the class.

        public override string ToString()
        {
            return $"ID: {ID} - Name: {Name} - Gender: {Gender} - Salary: {Salary} $/year";
        }
    }
}
