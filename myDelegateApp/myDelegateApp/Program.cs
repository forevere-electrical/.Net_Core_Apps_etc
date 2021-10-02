using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            delegateMethod weituo;
            weituo = callDelegate1;
            weituo += callDelegate2;
            weituo += callDelegate3;
            weituo();
            weituo.Invoke();
            Console.Read();
        }

        static void callDelegate1()
        {
            Console.WriteLine("this is a call to delegateMethod");
        }
        
        static void callDelegate2()
        {
            Console.WriteLine("Another call to delegateMethod");
        }

        static void callDelegate3()
        {
            Console.WriteLine("final call to delegateMethod");
        }
    }
    public delegate void delegateMethod();
}

    
