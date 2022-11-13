using System;

namespace AbstractTask
{
    public abstract class Animal
    {
        private string Name;
        public void setName(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    public class Dog : Animal
    {
        public Dog(String name)
        {
            setName(name);
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating", getName());
        }
    }
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Enter name of dog");
            Dog dog = new Dog(Console.ReadLine());
            dog.Eat();
            Console.ReadKey();
        }
    }
}
