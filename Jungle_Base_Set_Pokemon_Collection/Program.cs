using Jungle_Base_Set_Pokemon_Collection;

public class Program
{
    static void Main(string[] args)
    {
        Pokemon.LoadPokemonList();

        while (true)
        {
            Console.WriteLine("Please enter the name of the Pokemon you want to add to the collection (or type 'exit' to quit):");
            string pokemonName = Console.ReadLine();

            if (pokemonName.ToLower() == "exit")
                break;

            Pokemon.AddedToCollection(pokemonName);

            Pokemon.RemainingPokemon();

            Pokemon.SavePokemonList();
        }
    }
}