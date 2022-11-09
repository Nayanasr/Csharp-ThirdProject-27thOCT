using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdProject_27thOct
{
    delegate void serviceDelegate(string message);
    //delegate is agreement/contract between publisher and a subscriber
    internal class Service
    {
        public string credit { get; set; }
        public string debit { get; set; }

        //message services
        public void messageService(string a)
        {
            Console.WriteLine("amount has credited/debited to the user {0}", a);
        }

    }
    internal class Service1
    {
        public string credit { get; set; }
        public string debit { get; set; }

        //gmails services
        public void EmailService(string b)
        {
            Console.WriteLine("amount has credited/debited to the user {0}", b);
        }

    }
}
