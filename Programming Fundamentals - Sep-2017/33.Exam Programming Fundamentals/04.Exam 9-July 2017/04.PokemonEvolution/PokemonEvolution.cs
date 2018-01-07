using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string Name { get; set; }
        public List<KeyValuePair<string, int>> Evolution { get; set; }
    }
    class PokemonEvolution
    {
        static void Main()
        {
            List<Pokemon> dataPokemon = new List<Pokemon>();
            string input = Console.ReadLine();
            while(input != "wubbalubbadubdub")
            {
                var tokens = input
                    .Split(new char[] { ' ', '-', '>' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string pokemonName = tokens[0];
                if(tokens.Length > 1)
                {
                    string evolutionType = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if(!dataPokemon.Any(a => a.Name == pokemonName))
                    {
                        Pokemon pokemon = new Pokemon();
                        pokemon.Name = pokemonName;
                        pokemon.Evolution = new List<KeyValuePair<string, int>>();
                        pokemon.Evolution.Add(new KeyValuePair<string, int>(evolutionType, index));
                        dataPokemon.Add(pokemon);
                    }
                    else
                    {
                        var currentPokemon = dataPokemon.FirstOrDefault(n => n.Name == pokemonName);
                        if (dataPokemon.Any(name => name.Name == pokemonName))
                        {
                            currentPokemon.Evolution.Add(new KeyValuePair<string, int>(evolutionType, index));
                        }
                    }
                }
                else
                {
                    if (dataPokemon.Any(x => x.Name == pokemonName))
                    {
                        var currentPokemon = dataPokemon.FirstOrDefault(n => n.Name == pokemonName);
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in currentPokemon.Evolution)
                        {
                            Console.WriteLine($"{item.Key} <-> {item.Value}");
                        }
                    }
                }

                input = Console.ReadLine();
            }
            
            foreach (var item in dataPokemon)
            {
                Console.WriteLine($"# {item.Name}");
                var orderedEvolutions = item.Evolution
                    .OrderByDescending(v => v.Value)
                    .ToList();
                foreach (var typeAndIndex in orderedEvolutions)
                {
                    Console.WriteLine($"{typeAndIndex.Key} <-> {typeAndIndex.Value}");
                }
            }         
        }
    }
}
