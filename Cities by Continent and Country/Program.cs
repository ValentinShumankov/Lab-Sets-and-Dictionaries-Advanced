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
                string[] splitInput = Console.ReadLine().Split();
                string continent = splitInput[0];
                string country = splitInput[1];
                string city = splitInput[2];
                if ( !countriesList.ContainsKey( continent ) )
                {
                    countriesList.Add( continent, new Dictionary<string, List<string>>( ) );
                }
                if (! countriesList[continent].ContainsKey(country) )
                {
                    countriesList [ continent ].Add(country,new List<string>( ) );
                }
                if (! countriesList[continent][country].Contains(city) )
                {
                    countriesList [ continent ] [ country ].Add( city );
                }
            }
            foreach ( var continent in countriesList )
            {
                Console.WriteLine(continent.Key + ":");
                foreach ( var country in continent.Value )
                {
                    Console.WriteLine($" {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
