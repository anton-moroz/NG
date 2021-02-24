using System;
using ConsoleApp1;
using System.Linq;


namespace Lab1
{
    class MoneyHandler : BankomatHandlerClass
    {
        public override BankomatHandler Withdraw(int request)
        {
            // конвертуємо значення у ціле число, оскільки передатися може лише
            // значення, яке може стати цілим число
            int sum = Convert.ToInt32(request.ToString());

            //перевіряємо чи можемо видати дану купюру
            if (sum / GetCurrentBill() != 0)
            {
                // записуємо кількість купюр, які можемо зняти,
                // враховуючи обмеження по кількості купюр
                message = message + "Amount of " + GetCurrentBill().ToString() + " is -> "
                    + (sum / GetCurrentBill() % (bills[GetCurrentBill()] + 1)).ToString() + "\n";

                //зменшуємо суму для зняття на кількість купюр, які можемо зняти,
                //враховуючи обмеження по кількості купюр
                sum -= GetCurrentBill() * (sum / GetCurrentBill() % (bills[GetCurrentBill()] + 1));
            }
            //якщо сума для зняття = 0, то закінчуємо на поточному номіналі і виводимо повідомлення
            if (sum == 0)
            {
                Console.WriteLine(message);
                return null;
            }

            //якщо сума менша за найменший номінал, то показуємо помилку
            else if (sum < GetLastBill())
            {
                Console.WriteLine("The bankomat doesn't have such bills as " + sum.ToString());
                return null;
            }

            //якщо досі сума більша, ніж банкомат може видати, то показуємо помилку
            else if (n == bills.Count - 1)
            {
                Console.WriteLine("The bankomat doesn't have such amount of money!");
                return null;
            }
            //в іншому випаку можемо продовжувати
            else
            {
                n++;
                ToNextBill(new MoneyHandler());
                return base.Withdraw(sum);
            }
        }
    }//*/
}
