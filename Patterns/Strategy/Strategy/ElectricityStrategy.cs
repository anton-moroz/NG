using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ElectricityStrategy : IStrategy
    {
        double IStrategy.GetExpenses()
        {
            Random random = new Random();
            return (random.Next(40, 100) / 10);
        }
        void IStrategy.Move(double expenses, double fuel)
        {
            Console.WriteLine("Current fuel is elecctricity");
            Console.WriteLine("Fuel expenses per 100 km -> " + expenses.ToString());
            Console.WriteLine("You can go " + (Math.Round((fuel / expenses) * 10000) / 100).ToString() + " km\n");
        }
    }
}
