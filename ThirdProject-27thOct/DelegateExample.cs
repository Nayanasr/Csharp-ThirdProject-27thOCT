using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject_27thOct
{
    //keyword to declare a delegate is delegate.
    //delegate should be declared outside the class
    //delegate's signature must match method signature
    //delegate is a type safety function pointer
    delegate string message1Delegate(string message);

    public class DelegateExample
    {

        public string message1(string message)
        {
            string a = message;
            Console.WriteLine("hey this is from message1 {0}", a);
            return a;
        }

        public string message2(string message)
        {
            string a = message;
            Console.WriteLine("hey this is from message2 {0}", a);
            return a;
        }
    }
}
