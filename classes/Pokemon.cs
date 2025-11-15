using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPTP2.classes
{
    abstract class  Pokemon
    {
        protected string nom;
        protected int poids;
        protected float vitesse;
        private static List<Pokemon> listPokemons = new List<Pokemon>();
        

        public Pokemon(string nom, int poids)
        {
            this.nom = nom;
            this.poids = poids;
        }

        abstract public float ClacVitesse();
        abstract public void Afficher();

        //une méthode qui affiche tous les Pokemons créés
        public static void AfficherTousPokemon()
        {
            Console.WriteLine("Liste des Pokemon");
            foreach(Pokemon pokemon in listPokemons)
            {
                Console.WriteLine(pokemon);
            }
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
            Console.WriteLine($"La vitesse moyen des pokemons est :{vitesseMoyen} Km/h");
        }

        //une méthode qui ajoute un Pokemon
        public static void AjoutePokemon(Pokemon pokemon) {
            listPokemons.Add(pokemon);
        }


        //une méthode qui affiche le nombre de Pokemons de chaque catégorie
        public static void AfficherPokemonParCat()
        {
            Console.WriteLine("To be implemented");
        }


    }
}
