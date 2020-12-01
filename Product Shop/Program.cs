using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string [ ] args)
        {
            var listShops = new SortedDictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while ( (input = Console.ReadLine( )) != "Revision" )
            {
                var splitedInput = input.Split(", ");
                var shop = splitedInput[0];
                var product = splitedInput[1];
                var price = double.Parse(splitedInput[2]);
                if ( listShops.ContainsKey( shop ) )
                {
                    if ( !listShops [ shop ].ContainsKey( product ) )
                    {
                        listShops [ shop ].Add( product, price );
                    }
                    else
                    {
                        listShops [ shop ] [ product ] = price;
                    }
                }
                else
                {
                    listShops.Add( shop, new Dictionary<string, double>( ) { { product, price } } );
                }
            }
            foreach ( var shop in listShops )
            {
                Console.WriteLine(shop.Key + "->");
                foreach ( var product in shop.Value )
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

/*
 Write a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".  Keep in mind that if you receive a shop you already have received, you must collect its product information.
Your output must be ordered by shop name and must be in the format:
{shop}->
Product: {product}, Price: {price}
Examples

Input
lidl, juice, 2.30
fantastico, apple, 1.20
kaufland, banana, 1.10
fantastico, grape, 2.20
Revision
 
Output
fantastico->
Product: apple, Price: 1.2
Product: grape, Price: 2.2
kaufland->
Product: banana, Price: 1.1
lidl->
Product: juice, Price: 2.3
_____________________________

Input

tmarket, peanuts, 2.20
GoGrill, meatballs, 3.30
GoGrill, HotDog, 1.40
tmarket, sweets, 2.20
Revision

Output

GoGrill->
Product: meatballs, Price: 3.3
Product: HotDog, Price: 1.4
tmarket->
Product: peanuts, Price: 2.2
Product: sweets, Price: 2.2

 */