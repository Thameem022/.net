using System;
using System.Collections;


namespace ArrayListOfObjects
{
    public class Person
    {
        protected string? Name;
        protected int? Age;
        public Person(string? name, int? age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\n Age: " + Age;
        }
    }
    class ListOfObject
    {
        static void Main()
        {

            ArrayList PersonList = new ArrayList();
            for (int i = 0; i <= 2; i++)
            {
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                PersonList.Add(new Person(name, age));
            }
            foreach (Person person in PersonList)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadLine();

        }
    }
}