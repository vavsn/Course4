using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BankAccount
{
    /// <summary>
    /// класс реализации 1 упражнения домашнего задания
    /// https://gb.ru/lessons/180797/homework
    /// </summary>
    public class BankAcc

    {
        public enum TypeBankAccount : int
        {
            //дебетовый
            Deb = 1,
            //кредитный
            Cred,
            //текущий
            Curr
        }

        // количество символов в номере счета
        private static int _numsymbols = 25;

        // номер счета
        private static string _numaccount;
        // баланс
        private double _balance;
        // тип банковского счета:
        // - дебетовый
        // - кредитный
        // - текущий
        private TypeBankAccount _typebankaccount;

        public void SetNumAccount()
        {
            _numaccount = string.Empty;
            int[] loc = new int[25];
            Random rnd = new Random();

            for (int i=0; i < _numsymbols; i++)
            {
                loc[i] =  rnd.Next(0, 9);
            }
            _numaccount = String.Concat<int>(loc);
        }

        public string GetNumAccount()
        {
            return _numaccount;
        }

        public void SetBalance(double balance)
        {
            try
            {
                _balance = balance;
            }
            catch
            { 
            }
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void SetTypeBankAccount(TypeBankAccount typebankaccount)
        {
            try
            {
                _typebankaccount = typebankaccount;
            }
            catch
            { 
            }
        }

        public TypeBankAccount GetTypeBankAccount()
        {
            return _typebankaccount;

        }

        public string ToString()
        {
            return "Номер счета: " + BankAcc._numaccount + "\nБаланс: " + this._balance + 
                "\nТип счета: " + this._typebankaccount.ToString();
        }
    }
}
