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

            // step3 declare a delegate variable
            delegateMethod weituo;

            // step4 link delegate variable with delegate call methods created at step 2,
            // allow to link more than one method with += 
            weituo = callDelegate1;
            weituo += callDelegate2;
            weituo += callDelegate3;

            // Step5 call delegate variable as a method 
            weituo();
            Console.WriteLine("-----------Missing callDelegate2-------------");
            weituo -= callDelegate2;
            weituo();
            Console.WriteLine("-----------using delegateCall -------------");
            delegateMethod delegateCall = new delegateMethod(callDelegate1);
            delegateCall += callDelegate3;
            delegateCall();
            Console.Read();
        }

        // step2 write methods for delegate calls
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

    // step 1: declare a delegate method
    public delegate void delegateMethod();
}

    
