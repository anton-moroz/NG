using Lab1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        

        static void InputChecker(string value)
        {
            try
            {
                //якщо введено ціле число, яке менше або рівне 0
                if(Convert.ToInt32(value) <= 0)
                {
                    //показуємо помилку оскільки не можна зняти 0 або меншу суму
                    Console.WriteLine("Wrong amount of money!");
                }
                //починаємо процес зняття грошей
                new MoneyHandler().Withdraw(Convert.ToInt32(value));
            }
            //якщо введено символи, що не є цифрами або крапкою, показуємо помилку
            catch (Exception e)
            {
                Console.WriteLine("Wrong amount of money!");
                return;
            }

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("How much money do you want to withdraw?");
            InputChecker(Console.ReadLine());

            Console.WriteLine("\nTap Enter to exit...");
            Console.ReadLine();
        }
    }
}
