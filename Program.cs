
using OOPTP2.classes;

class Program
{
    static void Main()
    {
        Console.WriteLine("...");

        PokemonSpotifs pika = new PokemonSpotifs("Pikachu", 18, 2, 0.85f, 120);
        Pokemon.AjoutePokemon(pika);

        pika.Afficher();

        Pokemon.AfficherTousPokemon();
        Pokemon.AfficherNbrPokemon();
        Pokemon.VitesseMoyen();
    }
}