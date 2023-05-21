using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    enum StudentGrade
    {
        EXCELLENT,
        GOOD,
        SATISFACTORY
    }

    class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public override string ToString()
        {
            return $"{Name}: {AverageGrade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "John", AverageGrade = 10.8 },
                new Student { Name = "Alice", AverageGrade = 9.5 },
                new Student { Name = "Bob", AverageGrade = 11.2 },
                new Student { Name = "Jane", AverageGrade = 7.6 },
                new Student { Name = "Mark", AverageGrade = 12 }
            };

            Console.WriteLine("Список студентов до сортировки:");
            PrintStudents(students);

            Comparison<Student> rateCriteria = (s1, s2) => s2.AverageGrade.CompareTo(s1.AverageGrade);
            students.Sort(rateCriteria);

            Console.WriteLine("\nСписок студентов после сортировки:");
            PrintStudents(students);
        }

        static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
