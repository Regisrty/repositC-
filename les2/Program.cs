﻿using System;
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

            for (int i = 1; i <= 100; i++)


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz"+i);
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz"+i);
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz"+i);
                }


                else Console.WriteLine(i);


            Console.ReadLine();


        }
    }
    }