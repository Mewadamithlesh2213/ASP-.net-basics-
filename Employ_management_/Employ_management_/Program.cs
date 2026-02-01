using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ_management_
{
    class Employee
    {
        public int Id { set; get; } 
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- Employee Management System ---");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Search Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ViewEmployees(); break;
                    case 3: SearchEmployee(); break;
                    case 4: DeleteEmployee(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            employees.Add(new Employee(id, name, salary));
            Console.WriteLine("Employee Added Successfully");
        }

        static void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found");
                return;
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        static void SearchEmployee()
        {
            Console.Write("Enter Employee Id: ");
            int id = int.Parse(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);

            if (emp != null)
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            else
                Console.WriteLine("Employee not found");
        }

        static void DeleteEmployee()
        {
            Console.Write("Enter Employee Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            var emp = employees.Find(e => e.Id == id);

            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }


}
