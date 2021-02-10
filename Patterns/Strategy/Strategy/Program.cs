using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MovementStrategyClass movement = new MovementStrategyClass();
            movement.SetFuel(80);

            movement.SetMovementStrategy(new ElectricityStrategy());
            movement.SetMovementStrategy(new GasStrategy());
            movement.SetMovementStrategy(new BenzinStrategy());

            Console.WriteLine("\nTap Enter to exit...");
            Console.ReadLine();
        }
    }
}
