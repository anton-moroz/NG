using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MovementStrategyClass
    {
        double fuel;//кількість палива у баку

        CarMovementStrategy strategy;
        public MovementStrategyClass()
        {

        }
        public MovementStrategyClass(CarMovementStrategy _strategy, double _fuel)
        {
            this.strategy = _strategy;
            this.fuel = _fuel;
        }
        public void SetMovementStrategy(CarMovementStrategy _strategy)
        {
            this.strategy = _strategy;
            strategy.ChooseStrategy(this.fuel);
        }
        public void SetFuel(double _fuel)
        {
            this.fuel = _fuel;
        }
        public double GetFuel()
        {
            return this.fuel;
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 