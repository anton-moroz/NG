using System;

namespace ConsoleApp1
{
    class Program
    {
        public interface BankomatHandler
        {
            BankomatHandler SetNext(BankomatHandler handler);
            object Handle(object request);
        }
        abstract class BankomatHandlerClass : BankomatHandler
        {
            private BankomatHandler _nextHandler;

            public BankomatHandler SetNext(BankomatHandler handler)
            {
                this._nextHandler = handler;
                return handler;
            }
            public virtual object Handle(object request)
            {
                if (this._nextHandler != null)
                {
                    return this._nextHandler.Handle(request);
                }
                else
                {
                    return null;
                }
            }

            protected int[] bills = { 50, 20, 10, 5 };
            protected int[] amount = { 10, 10, 10, 10 };
            protected static int n = 0;//counter
            protected static string message = "Sucessfull withdrawn!\n";
        }

        class AmountHandler : BankomatHandlerClass
        {
            public override object Handle(object request)
            {
                int temp = 0;
                try
                {
                    temp = Convert.ToInt32(request.ToString());
                    if(temp == 0)
                    {
                        return "Wrong amount of money!";
                    }
                    SetNext(new MoneyHandler());
                    return base.Handle(temp);
                }
                catch (Exception e)
                {
                    return "Wrong amount of money!";
                }
            }
        }

        class MoneyHandler : BankomatHandlerClass
        {
            public override object Handle(object request)
            {
                int sum = Convert.ToInt32(request.ToString());
                if (sum >= bills[n] * amount[n])
                {
                    message = message + "Amount of " + bills[n].ToString() + " is -> " + amount[n].ToString() + "\n";
                    sum -= bills[n] * amount[n];
                }
                else
                {
                    message = message + "Amount of " + bills[n].ToString() + " is -> " + (sum / bills[n]).ToString() + "\n";
                    sum -= bills[n] * (sum / bills[n]);
                }
                if (sum == 0)
                {
                    return message;
                }
                else if (sum < bills[bills.Length - 1])
                {
                    return ("The bankomat doesn't have such bills as " + sum.ToString());
                }
                else if (n == bills.Length - 1)
                {
                    return "The bankomat doesn't have such amount of money ";
                }
                else
                {
                    n++;
                    SetNext(new MoneyHandler());
                    return base.Handle(sum);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you want to withdraw?");
            var handler = new AmountHandler();
            var result = handler.Handle(Console.ReadLine());
            Console.WriteLine("\n" + result.ToString() + "\nTap Enter to exit...");
            Console.ReadLine();
        }
    }
}
