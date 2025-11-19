
using OOPTP2.classes;

class Program
{
    static void Main()
    {
        // PokemonSpotifs - 2 instances
        PokemonSpotifs pika = new PokemonSpotifs("Pikachu", 18, 2, 0.85f, 120);
        Pokemons.AjoutePokemon(pika);

        PokemonSpotifs evoli = new PokemonSpotifs("Evoli", 6.5f, 4, 0.30f, 110);
        Pokemons.AjoutePokemon(evoli);

        // PokemonCasaniers - 2 instances
        PokemonCasaniers sala = new PokemonCasaniers("Salameche", 12, 2, 0.65f, 8);
        Pokemons.AjoutePokemon(sala);

        PokemonCasaniers ronflex = new PokemonCasaniers("Ronflex", 460, 2, 2.10f, 16);
        Pokemons.AjoutePokemon(ronflex);

        // PokemonDeMers - 2 instances
        PokemonDeMers rondou = new PokemonDeMers("Rondoudou", 45, 2);
        Pokemons.AjoutePokemon(rondou);

        PokemonDeMers carapuce = new PokemonDeMers("Carapuce", 9, 2);
        Pokemons.AjoutePokemon(carapuce);

        // PokemonCrosiere - 2 instances
        PokemonCrosiere bul = new PokemonCrosiere("Bulbizarre", 15, 3);
        Pokemons.AjoutePokemon(bul);

        PokemonCrosiere leviator = new PokemonCrosiere("Leviator", 235, 4);
        Pokemons.AjoutePokemon(leviator);


        pika.Afficher();
        sala.Afficher();
        rondou.Afficher();
        bul.Afficher();

        Pokemons.AfficherTousPokemon();
        Pokemons.AfficherNbrPokemon();
        Pokemons.AfficherNbrPokemonParCategorie();
        Pokemons.VitesseMoyen();
    }
}