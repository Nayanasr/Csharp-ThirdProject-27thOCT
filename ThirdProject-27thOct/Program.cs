using System;

namespace ThirdProject_27thOct
{
    class Program
    {
        static void Main(string[] args)
        {

            //DivNumbers d = new DivNumbers();
            //d.division(25, 0);
            ////d.division(25, 5);
            //Console.ReadKey();



            //Caluculator.cs
            //Attribute
            Calculator calculator = new Calculator();
            calculator.Add(20, 30);





            //DelegateExample.cs

            //calling methods without delegate
            //DelegateExample delegateExample = new DelegateExample();
            //delegateExample.message1("hey i am from obj ref call");
            //delegateExample.message2("hey i am from obj ref call");


            ////calling methods using delegate
            //DelegateExample delegateExample = new DelegateExample();
            //message1Delegate del = new message1Delegate(delegateExample.message2);
            //del("helo i am from delegate");

            ////Service.cs
            ////calling methods using delegate
            //Service service = new Service();
            //Service1 service1 = new Service1();
            //serviceDelegate del2 = new serviceDelegate(service.messageService);
            //serviceDelegate del3 = new serviceDelegate(service1.EmailService);

            ////invoking the methods
            //del2("this is message service method");
            //del2("this is message service method");

            ////DelegateExample1.cs
            //Console.WriteLine("My simple Delegate Program");

            //Mydelegate mdl = new Mydelegate(DelegateExample1.rectangle);
            //Mydelegate md2 = new Mydelegate(DelegateExample1.rectangle1);

            //Console.WriteLine("The Area of rectangle is {0}", mdl(4, 5));
            //Console.WriteLine("The Area of rectangle is {0}", mdl(8, 9));

            //Console.ReadKey();

            //DelegateExample2 testdelegate = new DelegateExample2();
            ////Instantiation
            //DelegateExample2.FirstDelegate fd1 = new DelegateExample2.FirstDelegate(testdelegate.fun1);
            //DelegateExample2.FirstDelegate fd2 = new DelegateExample2.FirstDelegate(testdelegate.fun2);
            //DelegateExample2.FirstDelegate fd3 = new DelegateExample2.FirstDelegate(testdelegate.fun3);

            ////Invocation 
            //fd1();
            //fd2();
            //fd3();

            //Console.ReadKey();


            //////MultiCastDelegate.cs
            //SingleAndMultiCastDelegate multiCastDelegate = new SingleAndMultiCastDelegate();
            //multiCastDelegate.CalculationOne();
            //multiCastDelegate.CalculationTwo();



            ////MultiCastExample.cs
            //Multicast1 multicast1 = new Multicast1();
            //multicast1.CalculationOne();
            //multicast1.CalculationTwo();

        }
    }
}
