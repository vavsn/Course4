using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc ba = new BankAcc();
            ba.SetNumAccount();
            ba.SetBalance((double)123.34);
            ba.SetTypeBankAccount(BankAcc.TypeBankAccount.Cred);
            Console.WriteLine("Данные счета:");
            Console.WriteLine(ba.ToString());
        }
    }
}
