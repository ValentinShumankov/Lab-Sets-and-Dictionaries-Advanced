using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int countStudent = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> students = new Dictionary<string, List<decimal>>();
            for ( int i = 0; i < countStudent; i++ )
            {
                string[] inputSplit = Console.ReadLine().Split();
                string name = inputSplit[0];
                decimal grade = decimal.Parse(inputSplit[1]);
                if ( students.ContainsKey( name ) )
                    students [ name ].Add( grade );
                else
                    students.Add( name, new List<decimal>( ) { grade } );
            }
            foreach ( var student in students )
            {
                Console.Write( $"{student.Key} -> " );
                foreach ( var grade in student.Value )
                {
                    Console.Write( $"{grade:f2} " );
                }
                Console.Write($"(avg: { student.Value.Average( ):f2})" );
                Console.WriteLine();
            }
        }
    }
}
/*
 Average Student Grades
Write a program, which reads a name of a student and his/her
grades and adds them to the student record, then prints the
student's names with their grades and their average grade.
Examples

 Input
7
Ivancho 5.20
Mariika 5.50
Ivancho 3.20
Mariika 2.50
Stamat 2.00
Mariika 3.46
Stamat 3.00


Output
Ivancho -> 5.20 3.20 (avg: 4.20)
Mariika -> 5.50 2.50 3.46 (avg: 3.82)
Stamat -> 2.00 3.00 (avg: 2.50)

____________________________
Input
4
Vladimir 4.50
Petko 3.00
Vladimir 5.00
Petko 3.66


OutPut
 Vladimir -> 4.50 5.00 (avg: 4.75)
Petko -> 3.00 3.66 (avg: 3.33)

_____________________________
Input 5
Gosho 6.00
Gosho 5.50
Gosho 6.00
Ivan 4.40
Petko 3.30

Output 
Gosho -> 6.00 5.50 6.00 (avg: 5.83)
Ivan -> 4.40 (avg: 4.40)
Petko -> 3.30 (avg: 3.30)
 */