using OOPandDesignPatterns.Abstraction;
using OOPandDesignPatterns.Encapsulation;
using OOPandDesignPatterns.Inheritance;
using OOPandDesignPatterns.Polymorphism;

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

//checkingAccount.Deposit(1000);
//Console.WriteLine(checkingAccount.GetBalance());

//checkingAccount.WithDraw(32);
//Console.WriteLine(checkingAccount.GetBalance());

Account savingsAccount = new SavingsAccount();

//savingsAccount.Deposit(100);
//Console.WriteLine(savingsAccount.GetBalance());

//savingsAccount.WithDraw(23);
//Console.WriteLine(savingsAccount.GetBalance());


//Inheritance
//var car = new Car(); //We cannot initialize  NumberOfDoors I mean which  the methods or field are created at Car class
//because when we get instance of Car like this "Vehicle car = new Car();" we can only get props and methods 
// where created at Vehicle and inherit Car class, instead, we can use like this "var car = new Car();" 
// and in this case we can access to Car's class props and method's
//car.Make = "Chevrolet";
//car.Model = "Matiz";
//car.Year = 2000;
//car.NumberOfDoors = 4;
//car.StartEngine();
//car.DisplayInformation();
//car.LockDoor();


//Polymorphism

Animal dog = new Dog();
dog.MakeSound();
dog.Eat();

Animal cat = new Cat();
cat.MakeSound();
cat.Eat();

