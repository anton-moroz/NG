using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IStrategy
    {
        void Move(double expenses, double fuel);
        double GetExpenses();
    }
}
