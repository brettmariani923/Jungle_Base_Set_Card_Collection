using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Jungle_Base_Set_Pokemon_Collection
{
   public class Pokemon
    {
        public static List<string> wantedList = new List<string>();

        public static void LoadPokemonList()
        {
            string filePath = "pokemon_list.txt";

            if (File.Exists(filePath))
            {
                wantedList = File.ReadAllLines(filePath).ToList();
            }
            else
            {
                wantedList = new List<string>
                {
                    "Clefable*", "Electrode*", "Flareon*", "Jolteon*", "Kangaskhan*",
                    "Mr. Mime*", "Nidoqueen*", "Pidgeot*", "Pinsir*", "Scyther*",
                    "Snorlax*", "Vaporeon*", "Venomoth*", "Victreebel*", "Vileplume*", "Wigglytuff*",
                    "Clefable", "Electrode", "Flareon", "Jolteon", "Kangaskhan",
                    "Mr. Mime", "Nidoqueen", "Pidgeot", "Pinsir", "Scyther",
                    "Snorlax", "Vaporeon", "Venomoth", "Victreebel", "Vileplume", "Wigglytuff",
                    "Butterfree", "Dodrio", "Exeggutor", "Fearow", "Gloom",
                    "Lickitung", "Marowak", "Nidorina", "Parasect", "Persian",
                    "Primeape", "Rapidash", "Rhydon", "Seaking", "Tauros", "Weepinbell",
                    "Bellsprout", "Cubone", "Eevee", "Exeggcute", "Goldeen", "Jigglypuff",
                    "Mankey", "Meowth", "Nidoran", "Oddish", "Paras", "Pikachu",
                    "Rhyhorn", "Spearow", "Venonat", "Poke Ball",
                };
            }
        }

        public static void SavePokemonList()
        {
            string filePath = "pokemon_list.txt";

            File.WriteAllLines(filePath, wantedList);
        }

        public static void AddedToCollection(string name)
        {
            string cleanedName = name.Trim();

            string match = wantedList.FirstOrDefault(p => string.Equals(p, cleanedName, StringComparison.OrdinalIgnoreCase));

            if (match != null)
            {
                wantedList.Remove(match);
                Console.WriteLine($"{match} has been added to your collection and removed from the wanted list!");
            }
            else
            {
                Console.WriteLine($"{name} is already in your collection or belongs to a different set!");
            }
        }

        public static void RemainingPokemon()
        {
            Console.WriteLine("Pokemon Cards remaining:");
            foreach (var name in wantedList)
            {
                Console.WriteLine(name);
                Console.WriteLine();
            }
        }
    }
}
