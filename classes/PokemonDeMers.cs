namespace OOPTP2.classes
{
    class PokemonDeMers : Pokemon
    {
        
        private int nbrNageoires;

        public PokemonDeMers(string nom, float poids, int nbrNageoires ) : base(nom, poids)
        {
           
            this.nbrNageoires = nbrNageoires;
        }

        public override float ClacVitesse()
        {
            //formule : (poids / 25) * nombre de nageoires
            vitesse = (poids / 25) * nbrNageoires;
            return vitesse;

        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis le pokémon {nom} mon poids est de {poids} kg, ma vitesse est de {ClacVitesse():F2} km/h j'ai {nbrNageoires} nageoires.");
        }
    }
}
