using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int inputCOunt = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for ( int i = 0; i < inputCOunt; i++ )
            {
                names.Add( Console.ReadLine( ) );
            }
            foreach ( var item in names )
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
 Record Unique Names
Write a program, which will take a 
list of names and print only the unique names in the list.
Examples

Input
8
Ivan
Pesho
Ivan
Stamat
Pesho
Alice
Peter
Pesho

Output
Ivan
Pesho
Stamat
Alice
Peter
======
Input
7
Lyle
Bruce
Alice
Easton
Shawn
Alice
Shawn
Peter

Output
Lyle
Bruce
Alice
Easton
Shawn
======
Input
6
Roki
Roki
Roki
Roki
Roki
Roki

Output
Roki

 */