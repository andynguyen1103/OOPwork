using System;

namespace GCD_BaitapOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManaging studentManaging = new StudentManaging();
            studentManaging.AddStudent();
            studentManaging.AddStudent();
            studentManaging.DisplayInfo();
        }
    }
}
