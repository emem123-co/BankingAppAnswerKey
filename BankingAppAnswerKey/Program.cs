namespace BankingAppAnswerKey;

internal class Program
{
    static void Main(string[] args)
    {
        Account a1 = new Account(); //instances of the Account class (two different instances of the Account class. Can pass these into a method.
        Account a2 = new Account();

        Console.WriteLine($"Account Balance is {a1.Balance:C}");
        a1.Deposit(500);
        Console.WriteLine($"Account Balance is {a1.Balance:C}");
       
        a1.Withdraw(230);
        Console.WriteLine($"Account Balance is {a1.Balance:C}");
   
        a1.Withdraw(300);
        Console.WriteLine($"Account Balance is {a1.Balance:C}");

        a1.Deposit(-200);
        Console.WriteLine($"Account Balance is {a1.Balance:C}");

        a1.Transfer(100, a2); //a1 is the first instance of an account, a2 is a variable but also another instance of another account. There are two properties needed because "Transfer" method requires two properties
          
          //a1 is calling the Transfer method. Transfer method will preform on this instance, which is using 100 and naming another variable (a2) which is pointing to another variable (ax) within the Transfer method. That variable (ax) then tells Transfer (if successful) to call the Deposit method, which will add the Amount indicated in the first variable of the Transfer method to the Balance.
    }
}
