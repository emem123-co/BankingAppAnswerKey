using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppAnswerKey;
internal class Savings : Account //inheriting Account class
{
    public decimal InterestRate {get; set;} = 0.12m; //m indicates this is a decimal, not a double(double is a floating number, which currency inherently is a non floating number);
    public void CalcAndPayInterest(int NbrOfMonths) //frequency of pay to balance
    {
        decimal Interest = Balance * (NbrOfMonths /12) * NbrOfMonths; //storing this amount in a variable called interest. this says once every month, the interest will be calclualted 
        Deposit(Interest); //passing new # called Interest, is passed through Deposit method
    }
    public Savings(string description) : base(description) //this is a constructor that says in order to run something through Savings method, you need a string that is called description). Base is the Account class which also is expecting a property (description).
    {
    }
}
