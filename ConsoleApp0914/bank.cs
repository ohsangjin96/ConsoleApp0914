using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0914
{
    public class BankAccount
    {
        private double interest = 0.2;   //이자율
        private string accNum;           //계좌번호
        private string name;             //예금주명
        private int balance = 0;         //잔액        

        public int Balance { get => balance; set => balance = value; }

        //출금
        public void OutputMoney(int amount)
        {
            this.balance = this.balance - amount;
        }

        //예금
        public void InputMoney(int amount)
        {
            this.balance = this.balance + amount + (int)(amount * interest);
        }
       
    }
    

    class bank
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.Balance = b1.Balance + 5000;
        }
    }
}