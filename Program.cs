using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc ba = new BankAcc(100, BankAcc.TypeBankAccount.Deb);
            string s1 = ba.Reverse(ba.numaccount);
            Console.WriteLine("Номер счета ДО реверсии:");
            Console.WriteLine(ba.numaccount);
            Console.WriteLine("Номер счета ПОСЛЕ реверсии:");
            Console.WriteLine(s1);
        }
    }
}
