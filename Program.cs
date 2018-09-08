using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingarray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  int numbers = new int[5];
              numbers[0] = 4;
              numbers[1] = 8;
              numbers[2] = 15;
              numbers[3] = 16;
              numbers[4] = 23 ;
              */
            string zig = ("Hey yo it,s my life and i have no idea what is like to be broken as fuck ..." + 
                " i feel that i am walking on a tight rope without a circus net i am a nervous wreck popping percocets ");
            char[] eminem = zig.ToCharArray();
            Array.Reverse(eminem);

                foreach(char zigchar in eminem)
            {
                Console.WriteLine(zigchar);

            }
            Console.ReadLine();


        }
    }
}
