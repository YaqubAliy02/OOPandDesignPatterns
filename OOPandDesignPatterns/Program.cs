using OOPandDesignPatterns.Abstraction;
using OOPandDesignPatterns.Coupling;
using OOPandDesignPatterns.Encapsulation;
//using OOPandDesignPatterns.Inheritance;
using OOPandDesignPatterns.Polymorphism;
using OOPandDesignPatterns.SOLID.D.Solution;


//using OOPandDesignPatterns.SOLID.D.Problem;

//using OOPandDesignPatterns.SOLID.L.Solution;
//using OOPandDesignPatterns.SOLID.L.Problem;

//using OOPandDesignPatterns.SOLID.I.Probem;
using OOPandDesignPatterns.SOLID.I.Solution;

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

/*
 //SOLID => L (Solution)
Shape rectangle = new Rectangle { Height = 5, Width = 4 };
Console.WriteLine("20");
Console.WriteLine("Area of the rectangle " + rectangle.Area);

Shape square = new Square { SideLength = 5 };
Console.WriteLine("25");
Console.WriteLine("Area of the square " + square.Area); 
*/

/*
 //SOLID => I(Problem)
var circle = new Circle();
circle.Radius = 10;
Console.WriteLine(circle.Area());
Console.WriteLine(circle.Volume());
*/

//SOLID => I(Solution)

/*
 Clients should not be forced to depend on interfaces' methods they not use.
 */
var circle = new Circle();
circle.Radius = 8;
Console.WriteLine(circle.Area());
//Console.WriteLine(circle.Volume()); // in this case it is not implemented that's why 
// it is showing error 


////SOLID => D(Problem)
//var car = new Car();//We actually have no way  when we create new car we have no way of 
//                    //changing the type of engine that car is built with
//                    //Currently if we want to change the type of engine so say we have currently we 
//                    //only have one engine class buy say we have another class called  electricEngine
//                    //or something else engine there is no way of changing engine type when we create 
//                    //a new car.You know we can't just add the engine here we have to change it within
//                    // the car class okay so this is not very flexible.
//car.StartCar();

//SOLID => D(Solution)

var car = new Car(new Engine());// The advantage of this principle is that it provides us with
                                // a lot more flexibility because now whenever we create new
                                // car we can pass in what type of engine we want  the car to 
                                // be built  with like so and currently  we only  have one type
                                // of engine but let's  just say we also had another type of engine
                                // interface and we can change it.
car.StartCar(); 