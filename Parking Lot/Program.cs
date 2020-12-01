using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string [ ] args)
        {
            string input = string.Empty;
            HashSet<string> parking = new HashSet<string>();
            while ( (input = Console.ReadLine()) != "END" )
            {
                string[] inputParams = Regex.Split(input, ", ");
                if ( inputParams[0] == "IN" )
                {
                    parking.Add( inputParams [ 1 ] );
                }
                else
                {
                    parking.Remove( inputParams [ 1 ] );
                }
            }
            if ( parking.Count > 0)
            {
                foreach ( var car in parking )
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine( "Parking Lot is Empty" );
            }


        }
    }
}

/*
 Parking Lot
Write a program that:
Records a car number for every car that enters the parking lot
Removes a car number when the car leaves the parking lot
The input will be a string in the format: [direction, carNumber]. You will be receiving commands, until the "END" command is given.
Print the car numbers of the cars, which are still in the parking lot:
Examples


Input
IN, CA2844AA
IN, CA1234TA
OUT, CA2844AA
IN, CA9999TT
IN, CA2866HI
OUT, CA1234TA
IN, CA2844AA
OUT, CA2866HI
IN, CA9876HH
IN, CA2822UU
END

 Output
CA9999TT
CA2844AA
CA9876HH
CA2822UU
==========
 Input 
IN, CA2844AA
IN, CA1234TA
OUT, CA2844AA
OUT, CA1234TA
END

Ouput

Parking Lot is Empty
 
 
 */