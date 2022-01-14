using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_BaitapOOP
{
    class Student:Member
    {
        public string Class { get; set; }
        public string Major { get; set; }
        public float WorkGrade { get; set; }
        public float MidTGrade { get; set; }
        public float EndTGrade { get; set; }

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            PhoneNum = 0;
            Email = "Unknown";
            Class = "Unknown";
            Major = "Unknown";
            WorkGrade = 0;
            MidTGrade = 0;
            EndTGrade = 0;
        }
        public Student(string name, int age, int phoneNum,string email, string Class, string major, float workGrade,float midGrade,float endGrade)
            : base(name, age, phoneNum, email)
        {
            this.Class = Class;
            Major = major;
            WorkGrade = workGrade;
            MidTGrade = midGrade;
            EndTGrade = endGrade;
        }
        public override void GetBasicInfo()
        {
            base.GetBasicInfo();
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("Average grade: {0}", (WorkGrade + MidTGrade + EndTGrade) / 3);
        }
        public void DisplayDetailGrade()
        {
            Console.WriteLine("Homework grade: " + WorkGrade);
            Console.WriteLine("Midterm grade: " + MidTGrade);
            Console.WriteLine("Final grade: " + EndTGrade);
        }

    }
}
