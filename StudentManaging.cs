using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_BaitapOOP
{
    class StudentManaging
    {
        List<Student> students;
        public StudentManaging()
        {
            students = new List<Student>();
        } 
        public void AddStudent()
        {
            Student student = new Student();
            Console.Write("Name: ");
           student.Name = Console.ReadLine();
            Console.Write("Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Phone number: ");
            student.PhoneNum = int.Parse(Console.ReadLine());
            Console.Write("Class: ");
            student.Class = Console.ReadLine();
            Console.Write("Major: ");
            student.Major = Console.ReadLine();
            Console.Write("Email: ");
            student.Email = Console.ReadLine();
            students.Add(student);
        }
        public void DisplayAllInfo()
        {
            if (students.Count==0)
            {
                Console.WriteLine("no student available");
                return;
            }
            foreach (var student in students)
            {
                student.GetBasicInfo();
                Console.WriteLine();
            }
        }


    }
}
