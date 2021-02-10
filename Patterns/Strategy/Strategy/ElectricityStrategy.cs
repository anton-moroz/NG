using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ElectricityStrategy : CarMovementStrategy
    {
        void CarMovementStrategy.ChooseStrategy(double fuel)
        {
            Random random = new Random();
            double expenses = random.Next(40, 100) / 10;
            Console.WriteLine("Current fuel is electricity");
            Console.WriteLine("Fuel expenses per 100 km -> " + expenses.ToString());
            Console.WriteLine("You can go " + (Math.Round((fuel / expenses) * 10000) / 100).ToString() + " km");
            Console.WriteLine();
        }
    }
}
