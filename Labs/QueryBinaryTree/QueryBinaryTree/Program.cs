using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            Tree<Employee> empTree = new Tree<Employee>(new Employee 
            { 
                Id = 1, 
                FirstName = "Kim", 
                LastName = "Ambercrombie", 
                Department = "IT" 
            });
            empTree.Insert(new Employee
            {
                Id = 2,
                FirstName = "Jeff",
                LastName = "Hay",
                Department = "Marketing"
            });
            empTree.Insert(new Employee
            {
                Id = 4,
                FirstName = "Charlie",
                LastName = "Herb",
                Department = "IT"
            });
            empTree.Insert(new Employee
            {
                Id = 6,
                FirstName = "Chris",
                LastName = "Preston",
                Department = "Sales"
            });
            empTree.Insert(new Employee
            {
                Id = 3,
                FirstName = "Dave",
                LastName = "Barnett",
                Department = "Sales"
            });
            empTree.Insert(new Employee
            {
                Id = 5,
                FirstName = "Tim",
                LastName = "Litton",
                Department = "Marketing"
            });
            /*
            Console.WriteLine("LIst of departments:");
            var depts = (from d in empTree select d.Department).Distinct();
            foreach (var dept in depts)
                Console.WriteLine(dept);
            var ITEmployees = from e in empTree where String.Equals(e.Department, "IT") select e;
            Console.WriteLine("");
            Console.WriteLine("All employees grouped by departement");
            var empByDep = from e in empTree group e by e.Department;
            foreach (var dept in empByDep)
            {
                Console.WriteLine($"Department: {dept.Key}");
                foreach (var emp in dept)
                    Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            }
            */
            Console.WriteLine("All employees: ");
            var allEmp = from e in empTree select e;
            foreach (var emp in allEmp)
                Console.WriteLine(emp);
            empTree.Insert(new Employee
            {
                Id = 7,
                FirstName = "David",
                LastName = "Simpson",
                Department = "IT"
            });
            Console.WriteLine();
            Console.WriteLine("Employee added");
            Console.WriteLine("All Employees");
            foreach (var emp in allEmp)
                Console.WriteLine(emp);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
