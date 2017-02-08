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
            Random randNum = new Random();



            int num;
            
            num = randNum.Next(1,6);

            switch (num)
            {
                case 3:
                    Console.WriteLine("3Num is  " + num);
                    break;
                case 4:
                    Console.WriteLine("4Num is euqal to" + num);
                    break;

                default:
                    Console.WriteLine("Nothing " + num);
                    break;



            }



            Console.ReadLine();

        }
        
       
    }
}