using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine("put array lenght");

            n = Convert.ToInt32(Console.ReadLine());

            int[] massiv = new int[n];



            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine("put array element");

                massiv[i] = Convert.ToInt32(Console.ReadLine());

            }

            int max = massiv[0];
            int min = massiv[0];

            for (int i = 0; i < n; i++)

            {

                if (massiv[i] > max)


                    max = massiv[i];


                if (massiv[i] < min)


                    min = massiv[i];

            }

            Console.WriteLine("Max element" + max);

            Console.WriteLine("Min element" + min);

            Console.ReadLine();

        
        }
    }
}
