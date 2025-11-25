
namespace OOPTP2.classes
{
    class Pokemons
    {
        private static List<Pokemon> listPokemons = new List<Pokemon>();

        //une méthode qui affiche tous les Pokemons créés
        public  void AfficherTousPokemon()
        {
            int count = 1;

            Console.WriteLine("\n╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 Liste des Pokemons                   ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine();
            foreach (Pokemon pokemon in listPokemons)
            {
                Console.Write($"{count} - ");
                pokemon.Afficher();
                Console.WriteLine();

                count++;
            }
            Console.WriteLine("════════════════════════════════════════════════════════");
            Console.WriteLine();
        }

        //Afficher le nombre total des Pokemons créés
        public void AfficherNbrPokemon()
        {
            Console.WriteLine($"Le nombre total des Pokemons créés");
            Console.WriteLine("╔════════════╦══════════════════════╗");
            Console.WriteLine($"║   Total #  ║ {listPokemons.Count,2} Pokemon(s) {" ",7}║");
            Console.WriteLine("╚════════════╩══════════════════════╝");
            Console.WriteLine();
        }


        //une méthode qui calcule la vitesse moyenne des Pokemons créés.
        public void VitesseMoyen()
        {
            float totalVitesse = 0;
            int countPokemon = listPokemons.Count;

            if (countPokemon == 0)
            {
                Console.WriteLine("Aucune moyenne");
                return;
            }
            foreach (Pokemon pokemon in listPokemons)
            {

                totalVitesse = totalVitesse + pokemon.CalcVitesse();

            }

            float vitesseMoyen = totalVitesse / countPokemon;
            Console.WriteLine($"La vitesse moyen des pokemons.");
            Console.WriteLine("╔════════════╦══════════════════════╗");
            Console.WriteLine($"║   Moyen #  ║ {vitesseMoyen:F2} Km/h {" ",11}║");
            Console.WriteLine("╚════════════╩══════════════════════╝");
            Console.WriteLine();
        }

        //une méthode qui ajoute un Pokemon
        public void AjoutePokemon(Pokemon pokemon)
        {
            listPokemons.Add(pokemon);
        }


        //une méthode qui affiche le nombre de Pokemons de chaque catégorie
        public void AfficherNbrPokemonParCategorie()
        {

            Console.WriteLine("\n╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║         Nombre de Pokemon par catégorie              ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════╣");
            Console.WriteLine($"Nombre total de Pokémon Sportifs créés : {PokemonSpotifs.nbrPokemonSpotifs}");
            Console.WriteLine($"Nombre total de Pokémon Casanier créés : {PokemonCasaniers.nbrPokemonCasaniers}");
            Console.WriteLine($"Nombre total de Pokémon Mers créés : {PokemonDeMers.nbrPokemonDeMers}");
            Console.WriteLine($"Nombre total de Pokémon Croisiere créés : {PokemonCrosiere.nbrPokemonCrosiere}");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.WriteLine();
        }
    }
}
