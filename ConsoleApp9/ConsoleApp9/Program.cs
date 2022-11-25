using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 6, 3,9,4,2,5 };
            for (int i = ints.Length-1;  i>0; i--)
            {
                int  max = i;
                for (int j = 0; j < i; j++)
                {
                    if (ints[j] > ints[max])
                    {
                        max = j;    
                    }
                }
                int tmp = ints[i];
                ints[i] = ints[max];    
                ints[max] = tmp;

            }
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i] + " ");

            }
            Console.ReadLine();
            
            
        }
    }
}
