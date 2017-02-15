using LibStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentData sd = new StudentData();
            List<Student> students = sd.GetFilteredStudents();
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }
    }
}
