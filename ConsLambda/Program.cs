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
        public delegate string ConvertString(string text);
        public delegate int CountString(string text);
        public delegate bool CheckString(string text1, string text2);
        public delegate bool CheckAge(Student student, int age);

        static void Main(string[] args)
        {
            StudentData sd = new StudentData();
            // List<Student> students = sd.GetFilteredStudents();
            List<Student> students = sd.GetAllStudents();
            List<String> fruits = new List<string> { "appel", "pear", "banana", "strawberry", "lemon" };

            foreach (string fruit in fruits)
            {
                // Console.WriteLine(fruit.ToUpper());
                ConvertString toCaps = x => x.ToUpper();
                CountString countString = x => x.Count();
                Console.WriteLine(toCaps(fruit) + " telt " + countString(fruit) + " tekens");
                // Console.WriteLine(fruit + " telt " + fruit.Count() + " tekens");
            }
            Console.WriteLine();
            for (int i = 0; i < fruits.Count()-1; i++)
            {
                CheckString checkString = (x, y) => x.Count() > y.Count();
                Console.WriteLine(fruits[i] + " contains more characters then " + fruits[i+1] + ": " + checkString(fruits[i], fruits[i+1]));
            }
            Console.WriteLine();
            foreach (Student student in students)
            {
                CheckAge checkAge = (x, y) => x.Age >= y;
                Console.WriteLine(student.FirstName +" "+ student.LastName + " is " + (checkAge(student, 21) ? "" : "not ") +"old enough.");
            }
            Console.ReadKey();
        }
    }
}
