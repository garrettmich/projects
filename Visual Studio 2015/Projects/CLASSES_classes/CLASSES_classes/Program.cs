using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student1;
            student1 = new Person();
            student1.SetName("Orion", "Hall");

            Console.WriteLine("First name is: " + student1.GetFullName());

            Person student2 = MakeSomeoneNew();

            Console.WriteLine("Student 2's name is: " + student2.GetFullName());

            Console.ReadLine();
        }

        static Person MakeSomeoneNew()
        {
            Person newperson = new Person();
            newperson.SetName("John", "Blank");
            return newperson;
        }
    }

    class Person
    {
        private string FirstName;
        private string LastName;
        private string PreferredTitle;

        public void SetName(string first, string last)
        {
            FirstName = first;
            LastName = last;
            PreferredTitle = "The Glorious";
        }

        public string GetFullName()
        {
            return (PreferredTitle + " " + FirstName + " " + LastName);
        }

    }


}