
using OOPTP2.classes;

class Program
{
    static void Main()
    {
        Console.WriteLine("...");

        PokemonSpotifs pika = new PokemonSpotifs("Pikachu", 18, 2, 0.85f, 120);
        Pokemon.AjoutePokemon(pika);

        PokemonCasaniers sala = new PokemonCasaniers("Salameche", 12, 2, 0.65f, 8);
        Pokemon.AjoutePokemon(sala);

        PokemonDeMers rondou = new PokemonDeMers("Rondoudou", 45, 2);
        Pokemon.AjoutePokemon(rondou);

        PokemonCrosiere bul = new PokemonCrosiere("Bulbizarre", 15, 3);
        Pokemon.AjoutePokemon(bul);


        pika.Afficher();

        Pokemon.AfficherTousPokemon();
        Pokemon.AfficherNbrPokemon();
        Pokemon.VitesseMoyen();
    }
}