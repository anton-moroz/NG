using System;
using System.Collections.Generic;
using ConsoleApp1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1;

namespace Lab1
{
    abstract class BankomatHandlerClass : BankomatHandler
    {
        private BankomatHandler _nextBill;

        public BankomatHandler ToNextBill(BankomatHandler bill)
        {
            this._nextBill = bill;
            return bill;
        }
        public virtual BankomatHandler Withdraw(int request)
        {
            if (this._nextBill != null)
            {
                return this._nextBill.Withdraw(request);
            }
            else
            {
                return null;
            }
        }
        protected Dictionary<byte, byte> bills = new Dictionary<byte, byte>();
        protected static byte n = 0;//counter
        protected static string message = "Sucessfull withdrawn!\n";
        public BankomatHandlerClass()
        {
            //додаємо наявні валюти та їх кількість у словник
            bills.Add(200, 100);
            bills.Add(100, 100);
            bills.Add(50, 100);
            bills.Add(20, 100);
            bills.Add(10, 10);
            bills.Add(5, 100);
        }

        protected byte GetCurrentBill()
        {
            byte i = 0;//counter
            foreach (var key in bills)
            {
                //знаходить потрібний нам номінал і повертає його
                if (i == n)
                {
                    return key.Key;
                }
                i++;
            }
            return 1;
        }
        protected byte GetLastBill()
        {
            byte i = 0;//counter
            foreach (var key in bills)
            {
                //знаходить останній номінал і повертає його
                if (i == bills.Count - 1)
                {
                    return key.Key;
                }
                i++;
            }
            return 1;
        }
    }
}
