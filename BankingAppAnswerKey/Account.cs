using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppAnswerKey;
public class Account //class 
{
    public int AccountID {get; set;} = 0; //property
    
    public string Description {get; set;} = string.Empty; //property
    public decimal Balance {get; set;} = 0; //property

    //methods
    public bool Deposit(decimal Amount)
    {
        if(Amount <= 0) 
        {
            Console.WriteLine("Amount must be greater than 0.");
            return false;
        }
        Balance += Amount;
        return true;
    }
    public bool Withdraw(decimal Amount)
    {
        if(Amount <= 0) //cannot withdraw a negative number
        {
            Console.WriteLine("Amount must be greater than 0."); //not the best place to put the console write line command (in this class, outside of the program class, but okay for this example).
            return false;
        }
        if(Amount > Balance) 
        {
            Console.WriteLine("Insufficient funds!");
            return false;
        }
        
        Balance -= Amount;
        return true;
    }
    public bool Transfer(decimal Amount, Account ax) /*ax is a variable of the type (class) named Account. in parethesis, what, if anything, needs to be passed through this method? defines the data type of the retun before the method name, then defines the data type of the variables that need to be passed through this method)*/
    {
        var success = Withdraw(Amount); //will assign "success" to either true or false (because of Withdraw method being called here. 
        if(success == true)
        {
            ax.Deposit(Amount); //instance of account(ax), accessing deposit method. It is a method within a method. When Transfer is called in Program class, this will preform withdraw from account a1 and deposit in account ax, since they are both within the transfer method.
        }
        return true;
    }

}