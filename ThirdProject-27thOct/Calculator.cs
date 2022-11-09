using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdProject_27thOct
{
    internal class Calculator   
    {
        [Obsolete("use add(list) rather than passing two int value")]
        public int Add(int a, int b)
        {
            Console.WriteLine(" sum is {0}", a + b);
            return a + b;
        }

        public int Add(List<int> numbers)
        {
            int sum = numbers.Sum();

            //foreach (int n in numbers)
            //{
            //    sum = sum + n;
            //}
            Console.WriteLine(sum);
            return sum;

        }

    }
}
