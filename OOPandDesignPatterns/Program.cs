using OOPandDesignPatterns.Abstraction;
using OOPandDesignPatterns.Encapsulation;

//Encapsulation 
BadBankAccount badBankAccount = new BadBankAccount();
//badBankAccount.balance = 100;
//Console.WriteLine(badBankAccount.balance);

BankAccount bankAccount = new BankAccount(100);

//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Deposit(300);
//Console.WriteLine(bankAccount.GetBalance());

//bankAccount.DrawBack(-200);
//Console.WriteLine(bankAccount.GetBalance());


//Abstaction

Account checkingAccount = new CheckingAccount();

checkingAccount.Deposit(1000);
Console.WriteLine(checkingAccount.GetBalance());

checkingAccount.WithDraw(32);
Console.WriteLine(checkingAccount.GetBalance());



Account savingsAccount = new SavingsAccount();

savingsAccount.Deposit(100);
Console.WriteLine(savingsAccount.GetBalance());

savingsAccount.WithDraw(23);
Console.WriteLine(savingsAccount.GetBalance());

