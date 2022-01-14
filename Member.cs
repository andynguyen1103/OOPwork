using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_BaitapOOP
{
    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNum { get; set; }
        public string Email { get; set; }

        public Member()
        {
            Name = "Unknown";
            Age = 0;
            PhoneNum = 0;
            Email = "Unknown";
        }
        public Member(string name, int age, int phoneNum, string email)
        {
            Name = name;
            Age = age>0?age:0;
            PhoneNum = phoneNum;
            Email = email;
        }
        public virtual void GetBasicInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Phone Number: " + PhoneNum);
            Console.WriteLine("Email: " + Email);
        }
    }
}
