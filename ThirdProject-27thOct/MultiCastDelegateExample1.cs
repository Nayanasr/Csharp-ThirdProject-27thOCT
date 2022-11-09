using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject_27thOct
{
    class MultiCastDelegateExample1
    {
        // declaring delegate
        public delegate void rectDelegate(double height,
                                          double width);

        // "area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        // "perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
}
