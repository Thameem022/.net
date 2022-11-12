using System;

namespace InterfaceApplication
{

    public interface IVehiculo
    {
        public void drive();
        public bool reFuel(int n);
    }

    public class Car : IVehiculo
    {
        int? fuelQauntity;
        public Car(int? num)
        {
            fuelQauntity = num;
        }
        public bool reFuel(int no)
        {

            fuelQauntity += no;
            return true;

        }
        public void drive()
        {
            if (fuelQauntity > 0)
            {

                Console.WriteLine("Driving car has {0} L", fuelQauntity);
            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }
    }
    class MainClass
    {
        static void Main()
        {
            Car car = new Car(0);
            Car car1 = new Car(40);
            Console.WriteLine("Enter quantity of fuel to be refilled car-1");
            int a = Convert.ToInt32(Console.ReadLine());

            car.reFuel(a);
            car.drive();
            Console.WriteLine("Enter quantity of fuel to be refilled in car-2");
            a = Convert.ToInt32(Console.ReadLine());
            car1.reFuel(a);
            car1.drive();
            Console.ReadKey();

        }
    }
}