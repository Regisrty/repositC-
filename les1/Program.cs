using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        
         {



                Console.WriteLine("Define number1");
                string s = Console.ReadLine();
                float a = float.Parse(s);

                Console.WriteLine("Define number2");
                string s2 = Console.ReadLine();
                float b = float.Parse(s2);

                float c = a % b;

            if (c != 0)
                Console.WriteLine("No. Cant be devided");
            

            if (c == 0)
                Console.WriteLine("Yes can be devided");
          

            // Console.WriteLine("res");
            //Console.WriteLine(c);
            Console.ReadLine();

            


        }
    }
    }