using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string [ ] args)
        {
            double[] scores = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double,int> input = new Dictionary<double, int>();
            for ( int i = 0; i < scores.Length; i++ )
            {
                if ( input.ContainsKey(scores[i]) )
                {
                    input [ scores [ i ] ] += 1;
                }
                else
                {
                    input.Add( scores [ i ], 1 );
                }
            }
            foreach ( var item in input )
            {
                Console.WriteLine(item.Key + " - " + item.Value + " times");
            }
        }
    }
}

/* 
 Count Same Values in Array
Write a program that counts in a
given array of double values the 
number of occurrences of each value. 
Examples 
 
Input
-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

Output
-2.5 - 3 times
4 - 2 times
3 - 4 times
-5.5 - 1 times

______________________________
Input 
 2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3

Output
2 - 3 times
4 - 6 times
5 - 4 times
3 - 7 times
 */
