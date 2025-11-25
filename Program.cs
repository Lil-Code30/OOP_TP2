
using OOPTP2.classes;

class Program
{
    static void Main()
    {

        Pokemons Pokemons = new Pokemons();

        // PokemonSpotifs - 2 instances
        Pokemons.AjoutePokemon(new PokemonSpotifs("Pikachu", 18, 2, 0.85f, 120));
        Pokemons.AjoutePokemon(new PokemonSpotifs("Evoli", 6.5f, 4, 0.30f, 110));

        // PokemonCasaniers - 2 instances
        Pokemons.AjoutePokemon(new PokemonCasaniers("Salameche", 12, 2, 0.65f, 8));
        Pokemons.AjoutePokemon(new PokemonCasaniers("Ronflex", 460, 2, 2.10f, 16));

        // PokemonDeMers - 2 instances
        Pokemons.AjoutePokemon(new PokemonDeMers("Rondoudou", 45, 2));
        Pokemons.AjoutePokemon(new PokemonDeMers("Carapuce", 9, 2));

        // PokemonCrosiere - 2 instances
        Pokemons.AjoutePokemon(new PokemonCrosiere("Bulbizarre", 15, 3));
        Pokemons.AjoutePokemon(new PokemonCrosiere("Leviator", 235, 4));


        Pokemons.AfficherTousPokemon();
        Pokemons.AfficherNbrPokemon();
        Pokemons.AfficherNbrPokemonParCategorie();
        Pokemons.VitesseMoyen();
    }
}