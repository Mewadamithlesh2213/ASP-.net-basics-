using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_First
{
    class Student
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }
    

    static void Main(string[] args)
        {
            Student s = new Student();
            s.Age = 1;
            Console.WriteLine(s.Age);
            Console.ReadLine();

        }
    }


}
