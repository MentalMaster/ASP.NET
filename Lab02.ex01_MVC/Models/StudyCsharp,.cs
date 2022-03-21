using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01.ex02_MVC.Models
{
    public enum AccountType 
    {
        Checking,
        Deposit
    }

    public struct BankAccount 
    { 
        public long accNo;
        public decimal accBal; 
        public AccountType accType;
        public override string ToString() 
        {         
            string str = $"Номер счета {accNo}, баланс {accBal}, тип {accType}";
            return str; 
        }
    }


    public class StudyCsharp_
    {
    }
}