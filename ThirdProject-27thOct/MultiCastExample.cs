using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject_27thOct
{
    public class MulticastExample
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    public class Multicast1
    {
        delegate void Calculate(int a, int b);

        public void CalculationOne()
        {
            MulticastExample multicastExample = new MulticastExample();
            Calculate del1 = new Calculate(multicastExample.Add);
            del1(5, 6);

        }

        public void CalculationTwo()
        {
            MulticastExample multicastExample = new MulticastExample();
            Calculate del1 = new Calculate(multicastExample.Add);
            del1 += multicastExample.sub;
            del1(30, 20);

        }
    }
}