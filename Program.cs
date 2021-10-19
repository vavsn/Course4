using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc ba = new BankAcc();
            Console.WriteLine("Данные счета1:");
            Console.WriteLine(ba.ToString());
            ba = new BankAcc(145);
            Console.WriteLine("Данные счета2:");
            Console.WriteLine(ba.ToString());
            ba = new BankAcc(BankAcc.TypeBankAccount.Deb);
            Console.WriteLine("Данные счета3:");
            Console.WriteLine(ba.ToString());
            ba = new BankAcc(324.09, BankAcc.TypeBankAccount.Cred);
            Console.WriteLine("Данные счета4:");
            Console.WriteLine(ba.ToString());
        }
    }
}
