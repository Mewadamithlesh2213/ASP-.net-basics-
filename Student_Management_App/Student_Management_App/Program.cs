using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_App
{
  public  class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string dept { get; set; }
        public int marks { get; set; }

        public Student(int id, string name, int age, string dept, int marks)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.dept = dept;
            this.marks = marks;
        }

    }
    class Program
    {

        public static List<Student> list = new List<Student>();

        static void AddStudent()
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter dept: ");
            string dept = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            list.Add(new Student(id, name, age, dept, marks));
            Console.WriteLine("Student Added Successfully");
        }

        static void ViewStudent()
        {
            Console.WriteLine("Enter id: ");

            int id = int.Parse(Console.ReadLine());


            var Stu = list.Find(e => e.id == id);

            if (Stu != null)
            {
                Console.WriteLine($"ID: {Stu.id}, Name: {Stu.name}, Age: {Stu.age}, Dept: {Stu.dept}, Marks: {Stu.marks}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }

        }
        static void RemoveStudent()
        {
            Console.WriteLine("Enter Id ");

            int id = int.Parse(Console.ReadLine());

            var Stu = list.Find(e => e.id == id);

            if (Stu != null)
            {
                list.Remove(Stu);
                Console.WriteLine("Student Deleted SuccussFully: ");
            }
            else
            {
                Console.WriteLine("Student is Not Found: ");
            }


        }

        static void ViewAllStudent()
        {

            if (list.Count == 0)
            {
                Console.WriteLine("Students not found");
                return;
            }
            foreach (var Stu in list)
            {

                Console.WriteLine($"ID: {Stu.id}, Name: {Stu.name}, Salary: {Stu.age}, Dept: {Stu.dept}, Marks: {Stu.marks}");
            }

        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. ADD Student: ");
                Console.WriteLine("2. view Student: ");
                Console.WriteLine("3. Remove Stident: ");
                Console.WriteLine("4. View All Students: ");
                Console.WriteLine("5. Exit: ");


                Console.WriteLine("Enter Choice");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1: AddStudent(); break;
                    case 2: ViewStudent(); break;
                    case 3: RemoveStudent(); break;
                    case 4: ViewAllStudent(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice"); break;

                }
            }
        }
    }
}


