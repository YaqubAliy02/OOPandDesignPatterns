using OOPandDesignPatterns.Encapsulation;

//Encapsulation 
BadBankAccount badBankAccount = new BadBankAccount();
badBankAccount.balance = 100;
//Console.WriteLine(badBankAccount.balance);

BankAccount bankAccount = new BankAccount(100);

//Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(300);
//Console.WriteLine(bankAccount.GetBalance());

bankAccount.DrawBack(-200);
Console.WriteLine(bankAccount.GetBalance());

