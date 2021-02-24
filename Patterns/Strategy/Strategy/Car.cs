using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Car 
    {
        IStrategy strategy;
        double fuel;
        public Car(double _fuel)
        {
            this.fuel = _fuel;
        }
        public void SetStrategy(IStrategy _strategy)
        {
            this.strategy = _strategy;
        }
        public void Move()
        {
            strategy.Move(strategy.GetExpenses(), fuel);
        }
    }
}
