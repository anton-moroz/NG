using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class BenzinStrategy : IStrategy
    {
        double IStrategy.GetExpenses()
        {
            Random random = new Random();
            return (random.Next(70, 200) / 10);
        }
        void IStrategy.Move(double expenses, double fuel)
        {
            Console.WriteLine("Current fuel is benzin");
            Console.WriteLine("Fuel expenses per 100 km -> " + expenses.ToString());
            Console.WriteLine("You can go " + (Math.Round((fuel / expenses) * 10000) / 100).ToString() + " km\n");
        }
    }
}
