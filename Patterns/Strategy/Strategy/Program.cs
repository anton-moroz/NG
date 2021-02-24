using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write amount of fuel: ");
            Car car = new Car(Convert.ToDouble(Console.ReadLine()));

            car.SetStrategy(new ElectricityStrategy());
            car.Move();
            
            car.SetStrategy(new BenzinStrategy());
            car.Move();
            
            car.SetStrategy(new GasStrategy());
            car.Move();

            Console.WriteLine("\nTap Enter to exit...");
            Console.ReadLine();
        }
    }
}
