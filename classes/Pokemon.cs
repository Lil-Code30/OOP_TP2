namespace OOPTP2.classes
{
    abstract class  Pokemon
    {
        protected string nom;
        protected float poids;
        protected float vitesse;
        private static List<Pokemon> listPokemons = new List<Pokemon>();
        

        public Pokemon(string nom, float poids)
        {
            this.nom = nom;
            this.poids = poids;
            vitesse = 0;
        }

        abstract public float ClacVitesse();
        abstract public void Afficher();

        //une méthode qui affiche tous les Pokemons créés
        public static void AfficherTousPokemon()
        {
            int count = 1;
           
            Console.WriteLine("\n╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 Liste des Pokemons                   ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            foreach (Pokemon pokemon in listPokemons)
            {
                Console.WriteLine($"{count} - Pokemon '{pokemon.nom}' de type {pokemon.GetType()}");
                
                count++;
            }
            Console.WriteLine("════════════════════════════════════════════════════════");
            Console.WriteLine();
        }

        //Afficher le nombre total des Pokemons créés
        public static void AfficherNbrPokemon()
        {
            Console.WriteLine($"Le nombre total des Pokemons créés");
            Console.WriteLine("╔════════════╦══════════════════════╗");
            Console.WriteLine($"║   Total #  ║ {listPokemons.Count,2} Pokemon(s) {" ",7}║");
            Console.WriteLine("╚════════════╩══════════════════════╝");
            Console.WriteLine();
        }


        //une méthode qui calcule la vitesse moyenne des Pokemons créés.
        public static void VitesseMoyen()
        {
            float totalVitesse = 0;
            int countPokemon = listPokemons.Count;
            foreach (Pokemon pokemon in listPokemons)
            {

                totalVitesse = totalVitesse + pokemon.vitesse;

            }

            float vitesseMoyen = totalVitesse / countPokemon;
            Console.WriteLine($"La vitesse moyen des pokemons.");
            Console.WriteLine("╔════════════╦══════════════════════╗");
            Console.WriteLine($"║   Moyen #  ║ {vitesseMoyen:F2} Km/h {" ",11}║");
            Console.WriteLine("╚════════════╩══════════════════════╝");
            Console.WriteLine();
        }

        //une méthode qui ajoute un Pokemon
        public static void AjoutePokemon(Pokemon pokemon) {
            listPokemons.Add(pokemon);
        }


        //une méthode qui affiche le nombre de Pokemons de chaque catégorie
        public static void AfficherNbrPokemonParCategorie()
        {
            foreach (Pokemon pokemon in listPokemons)
            {
                {
                    Console.WriteLine("bientot...");
                }
            }
        }


    }
}
