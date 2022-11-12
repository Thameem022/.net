// See https://aka.ms/new-console-template for more information
using System;

namespace FirstTask
{

    public class Person
    {
        protected string? Name;
        public Person(string? str)
        {
            Name = str;
        }
        public override string ToString()
        {
            return "Person name is: " + Name;
        }
        ~Person()
        {
            Name = "";
        }

    }
    public class Student : Person
    {
        public Student(string? Name) : base(Name)
        { }

        public string study()
        {
            return (Name + " is studying");
        }
    }
    public class Teacher : Person
    {
        public Teacher(string? Name) : base(Name)
        { }

        public string explain()
        {
            return (Name + " is explaining");
        }
    }
    class MainClass
    {
        static void Main()
        {
            int count = 3;

            Console.WriteLine("Enter student name");
            Student student = new Student(Console.ReadLine());
            Console.WriteLine(student.study() + "\n");

            Console.WriteLine("Enter teacher name");
            Teacher teacher = new Teacher(Console.ReadLine());
            Console.WriteLine(teacher.explain()+ "\n");

            Person[] persons = new Person[3];
            Console.WriteLine("Enter 3 person's name: \n");
            for (int i = 0; i < count; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            foreach (object person in persons)
            {
                Console.WriteLine(person.ToString()+ "\n");
            }
        }
    }
}
