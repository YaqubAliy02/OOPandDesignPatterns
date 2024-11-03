using OOPandDesignPatterns.Abstraction;
using OOPandDesignPatterns.Coupling;
using OOPandDesignPatterns.Encapsulation;
using OOPandDesignPatterns.Inheritance;
using OOPandDesignPatterns.Polymorphism;
//using OOPandDesignPatterns.SOLID.L.Problem;
using OOPandDesignPatterns.SOLID.L.Solution;

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
var car = new Car(); //We cannot initialize  NumberOfDoors I mean which  the methods or field are created at Car class
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
//dog.MakeSound();
//dog.Eat();
//
//Animal cat = new Cat();
//cat.MakeSound();
//cat.Eat();


//Coupling

Order order = new Order(new EmailSender());
//order.PlaceOrder();

Order order1 = new Order(new SmsSender());
//order1.PlaceOrder();


////SOLID => L (Problem)
//var rect = new Square();
//rect.Height = 10;
//rect.Width = 5;
//Console.WriteLine("Expected area = 10 * 5 = 50");
//Console.WriteLine("Calculated area = " + rect.Area);

/*
 Objects of a superclass should be replaceable  with objects of its subclass without
 affecting the correctness of the program.
 */
//SOLID => L (Solution)
Shape rectangle = new Rectangle { Height = 5, Width = 4 };
Console.WriteLine("20");
Console.WriteLine("Area of the rectangle " + rectangle.Area);

Shape square = new Square { SideLength = 5 };
Console.WriteLine("25");
Console.WriteLine("Area of the square " + square.Area);



