using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string [ ] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regGuest = new HashSet<string>();

            string input = string.Empty;
            while ( (input = Console.ReadLine()) != "PARTY" )
            {
                if ( char.IsDigit(input[0]) )
                {
                    vipGuests.Add( input );
                }
                else
                {
                    regGuest.Add( input );
                }
            }
           
            while ( (input = Console.ReadLine()) != "END" )
            {
                if ( char.IsDigit(input[0]) )
                {
                    vipGuests.Remove( input );
                }
                else
                {
                    regGuest.Remove( input );
                }
            }

            Console.WriteLine(vipGuests.Count + regGuest.Count);
            foreach ( var guest in vipGuests )
            {
                Console.WriteLine(guest);
            }
            foreach ( var guest in regGuest )
            {
                Console.WriteLine(guest);
            }
        }
    }
}
/*
 Party
There is a party. Many guests are invited and there are two types of them: VIP and Regular.
When a guest comes, check if he/she exists in any of the two reservation lists.
All reservation numbers will be with the length of 8 chars.
All VIP numbers start with a digit.
First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
"PARTY" – After this command you will begin receiving the reservation numbers of the people, who actually came to the party.
"END" –The party is over and you have to stop the program and print the appropriate output.
In the end, print the count of the quests who didn't come to the party and afterwards, print their reservation numbers. the VIP guests must be first.
Examples
 
 Input
7IK9Yo0h
9NoBUajQ
Ce8vwPmE
SVQXQCbc
tSzE5t0p
PARTY
9NoBUajQ
Ce8vwPmE
SVQXQCbc
END

Output
2
7IK9Yo0h
tSzE5t0p
=======
Input
m8rfQBvl
fc1oZCE0
UgffRkOn
7ugX7bm0
9CQBGUeJ
2FQZT3uC
dziNz78I
mdSGyQCJ
LjcVpmDL
fPXNHpm1
HTTbwRmM
B5yTkMQi
8N0FThqG
xys2FYzn
MDzcM9ZK
PARTY
2FQZT3uC
dziNz78I
mdSGyQCJ
LjcVpmDL
fPXNHpm1
HTTbwRmM
B5yTkMQi
8N0FThqG
m8rfQBvl
fc1oZCE0
UgffRkOn
7ugX7bm0
9CQBGUeJ
END

Output
2
xys2FYzn
MDzcM9ZK

 */