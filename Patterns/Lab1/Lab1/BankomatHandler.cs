using System;

namespace Lab1
{
    interface BankomatHandler
    {
        BankomatHandler ToNextBill(BankomatHandler bill);
        BankomatHandler Withdraw(int request);
    }
}
