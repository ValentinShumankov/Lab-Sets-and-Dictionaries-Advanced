using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string [ ] args)
        {
            var countriesList = new Dictionary<string, Dictionary<string, List<string>>>();
            int inputCOunt = int.Parse(Console.ReadLine());
            for ( int i = 0; i < inputCOunt; i++ )
            {
                string[] splitInput = Console.ReadLine().Split(" ");
                string continent = splitInput[0];
                string country = splitInput[1];
                string city = splitInput[2];
                if ( !countriesList.ContainsKey( continent ) )
                {
                    countriesList.Add( continent, new Dictionary<string, List<string>>( ) );
                }
                if ( !countriesList [ continent ].ContainsKey( country ) )
                {
                    countriesList [ continent ].Add( country, new List<string>( ) );
                }
                if (! countriesList[continent][country].Contains(city) )
                {
                    countriesList [ continent ] [ country ].Add( city );
                }
            }
            foreach ( var continent in countriesList )
            {
                Console.WriteLine( continent.Key + ":" );
                foreach ( var country in continent.Value )
                {
                    Console.WriteLine( $"   {country.Key} -> {string.Join( ", ", country.Value )}" );
                }
            }
        }
    }
}

/*
 Cities by Continent and Country
Write a program that reads continents, countries and their cities, puts them in a nested dictionary and prints them.
Examples

Input
9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsaw
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai

Output
Europe:
  Bulgaria -> Sofia, Plovdiv
  Poland -> Warsaw, Poznan
  Germany -> Berlin
Asia:
  China -> Beijing, Shanghai
  Japan -> Tokyo
Africa:
  Nigeria -> Abuja
===============================
Input 
3
Europe Germany Berlin
Europe Bulgaria Varna
Africa Egypt Cairo


Output
 Europe:
  Germany -> Berlin
  Bulgaria -> Varna
Africa:
  Egypt -> Cairo

==============================
Input
8
Africa Somalia Mogadishu
Asia India Mumbai
Asia India Delhi
Europe France Paris
Asia India Nagpur
Europe Germany Hamburg
Europe Poland Gdansk
Europe Germany Danzig


Output
Africa:
  Somalia -> Mogadishu
Asia:
  India -> Mumbai, Delhi, Nagpur
Europe:
  France -> Paris
  Germany -> Hamburg, Danzig
  Poland -> Gdansk

 */