﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

        public string numaccount
        {
            set 
            {
                _numaccount = string.Empty;
                int[] loc = new int[25];
                Random rnd = new Random();

                for (int i = 0; i < _numsymbols; i++)
                {
                    loc[i] = rnd.Next(0, 9);
                }
                _numaccount = String.Concat<int>(loc);
            }
            get 
            {
                return _numaccount;
            }
        }

        public double balance
        {
            set 
            {
                try
                {
                    _balance = Math.Round(value, 2);
                }
                catch
                {
                }
            }
            get 
            {
                return _balance;
            }
        }
        public TypeBankAccount typebankaccount
        {
            set
            {
                try
                {
                    _typebankaccount = value;
                }
                catch
                {
                }
            }
            get
            {
                return _typebankaccount;
            }
        }

        public BankAcc() 
        {
            numaccount = "";
            balance = 0.0;
            typebankaccount = TypeBankAccount.Curr;
        }
        public BankAcc(double bal)
        {
            numaccount = "";
            balance = bal;
            typebankaccount = TypeBankAccount.Curr;
        }
        public BankAcc(TypeBankAccount tba)
        {
            numaccount = "";
            balance = 0.0;
            typebankaccount = tba;
        }
        public BankAcc(double bal, TypeBankAccount tba)
        {
            numaccount = "";
            balance = bal;
            typebankaccount = tba;
        }
        public string ToString()
        {
            return "Номер счета: " + this.numaccount + "\nБаланс: " + this.balance + 
                "\nТип счета: " + this.typebankaccount.ToString();
        }

        public void Transfer(
            BankAcc OutBankAcc, // банковский счет, источник перевода
            double Summ         // сумма перевода
            )
        {
            if (OutBankAcc is null)
            {
                throw new Exception("Не указан номер счета");
            }
            if (Summ <= 0)
            {
                throw new Exception("Не указана либо отрицательная сумма перевода");
            }
            if (OutBankAcc.balance < Summ)
            {
                throw new Exception("На счету недостаточно средств");
            }

            balance += Summ;
            OutBankAcc.balance -= Summ;
        }

        public string Reverse(string input)
        {
            char[] array = input.ToCharArray();
            char ch1 = new char();
            for (int i = 0; i<= input.Length / 2; i++)
            {
                ch1 = array[i];
                array[i] = array[input.Length - i-1];
                array[input.Length - i-1] = ch1;
            }
            return new string(array);
        }
    }
}
