using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc ba = new BankAcc(100, BankAcc.TypeBankAccount.Deb);
            Console.WriteLine("Данные счета1:");
            Console.WriteLine(ba.ToString());
            BankAcc ba1 = new BankAcc(548.213, BankAcc.TypeBankAccount.Deb);
            Console.WriteLine("Данные счета2:");
            Console.WriteLine(ba1.ToString());
            try
            {
                ba.Transfer(ba1, 600);
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"Отказ: {e.Message}");
                Console.WriteLine();
            }
            Console.WriteLine("Данные счета1 после операции:");
            Console.WriteLine(ba.ToString());
        }
    }
}
