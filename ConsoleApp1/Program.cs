using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730385

{
    class arshdeep
    {
        static void Main(string[] args)
        {
            MethodA();
        }
        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine("i am stuck in an infinite loop");
            }
        }
        public static bool peanut()
        {
            return true;
        }

    }
}                   

  
    

