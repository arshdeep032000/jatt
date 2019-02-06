using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730385

{
    class arshdeep
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
        }
        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine(i);
                if(i>10)
                {
                    return;
                }
            }
        }
        public static bool peanut()
        {
            i++;
            return true;
        }

    }
}                   

  
    

