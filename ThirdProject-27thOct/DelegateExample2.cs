using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject_27thOct
{
    public class DelegateExample2
    {
        //Declaration
        //Creating Delegates with no parameters and no return type.
        public delegate void FirstDelegate();

        public void fun1()
        {
            Console.WriteLine("I am Function 1");
        }
        public void fun2()
        {
            Console.WriteLine("I am Function 2");
        }
        public void fun3()
        {
            Console.WriteLine("I am Function 3");
        }
    }
}