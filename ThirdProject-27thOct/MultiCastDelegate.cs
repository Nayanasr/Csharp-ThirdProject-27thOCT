using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject_27thOct
{
    //class 1
    public class MultiCastDelegate   
    {
        //A delegate is a reference type that holds the reference of a class method.
        //Any method which has the same signature as delegate can be assigned to delegate.

        //Single cast Delegate

        //A single cast delegate holds the reference of only single method.In previous example, created delegate is a single cast delegate.


        //Multi Cast Delegate

        //A delegate which holds the reference of more than one method is called multi-cast delegate.

        public void Add(int x, int y)
        {
            Console.WriteLine($"Add Method called Output - {x + y}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract Method called Output - {x - y}");
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply Method called Output - {x * y}");
        }

    }


    //class 2

    public class SingleAndMultiCastDelegate
    {

        public delegate void Action(int x, int y);

        //Single Delegate
        public void CalculationOne()
        {
            MultiCastDelegate multicast = new MultiCastDelegate();
            Action action = new Action(multicast.Add);

            action(5, 5);
            Console.ReadKey();
        }


        //Multi Delegate
        public void CalculationTwo()
        {
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate(); //class instance
            Action action = new Action(multiCastDelegate.Add); //delegate instance

            action += new Action(multiCastDelegate.Subtract);
            action += new Action(multiCastDelegate.Multiply);

            action(5, 5);
            Console.ReadKey();

        }//CalculationTwo method ends
    }
}
